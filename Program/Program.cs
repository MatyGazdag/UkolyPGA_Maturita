using System.Globalization;
using System.IO;

namespace Program
{
    internal class Program
    {
        public static int maximalniPocetRadku = 40;

        static void Main(string[] args)
        {
            if(args.Length > 1)
            {
                Console.WriteLine("Chyba, můžeš zadat jenom jeden parametr");
                return;
            }
            string cesta = args[0];
            if (!File.Exists(cesta))
            {
                Console.WriteLine("Chyba, soubor neexistuje");
                return;
            }

            Console.WriteLine("Načítám soubor...");
            int pocetRadku = PocetRadku(cesta);
            if(pocetRadku > maximalniPocetRadku)
            {
                Console.WriteLine("Chyba, je podporováno maximální počet řádků: " + maximalniPocetRadku);
                return;
            }

            int[] poleCisel = new int[pocetRadku];
            int index = 0;
            using (var reader = new StreamReader(cesta))
            {
                string radek = "";

                while ((radek = reader.ReadLine()) != null && index < pocetRadku)
                {
                    int cislo = 0;
                    if (int.TryParse(radek, out cislo))
                    {
                        poleCisel[index] = cislo;
                    }else
                    {
                        poleCisel[index] = cislo;
                    }
                    index++;
                }
            }

            poleCisel = seradPole(poleCisel);

            VytvorHTML(cesta, poleCisel);
        }

        public static void VytvorHTML(string cesta, int[] poleCisel)
        {
            Console.WriteLine("Exportuji...");
            int max = poleCisel[poleCisel.Length - 1];
            int min = poleCisel[0];

            string[] procenta = new string[poleCisel.Length];

            for (int i = 0; i < poleCisel.Length; i++)
            {
                float procento = 0;
                if (poleCisel[i] < 0)
                {
                    procento = (poleCisel[i] / (float)min) * 100;
                    procenta[i] = $"width:{(procento).ToString().Replace(",", ".")}%; background-color: blue;";
                }
                else
                {
                    procento = (poleCisel[i] / (float)max) * 100;
                    procenta[i] = $"width:{(procento).ToString().Replace(",", ".")}%; background-color: red;";
                }
            }

            using (var writer = new StreamWriter("output.html"))
            {
                writer.WriteLine(@"
                <!DOCTYPE html>
                <html lang=""en"">
                    <head>
                        <meta charset=""UTF-8"">
                        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                        <title>Výstup</title>

                        <style>
                            grid
                            {
                                display: flex;
                                flex-direction: column-reverse;
                                margin-left: 30px;
                            }

                            div
                            {
                                float: left;
                                background-color: red;
                                height: 10px;
                            }

                            p
                            {
                                text-align: left;
                                min-width: 50px;
                            }

                            cell
                            {
                                display: flex;
                                align-items: center;
                                width: 80%;
                                height: 30px;
                            }
                        </style>
                    </head>
                    <body>
                    <h1>Export dat</h1>
                    <grid>");


                for(int i = 0; i < poleCisel.Length; i++)
                {
                    writer.WriteLine("<cell>");
                    writer.WriteLine($"<p>{poleCisel[i]}</p>");
                    writer.WriteLine($"<div style=\"{procenta[i]}\"></div>");
                    writer.WriteLine("</cell>");
                }

                writer.WriteLine(@$"
                    </grid>
                    </body>
                </html>");
            }
            Console.WriteLine("Hotovo.");
        }

        public static int PocetRadku(string cesta)
        {
            int pocet = 0;
            using (var reader = new StreamReader(cesta))
            {
                string radek = "";
                while ((radek = reader.ReadLine()) != null)
                {
                    pocet++;
                }
            }
            return pocet;
        }

        public static int[] seradPole(int[] pole)
        {
            Console.WriteLine("Řadím čísla...");
            for (int i = 0; i < pole.Length; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < pole.Length; j++)
                {
                    if(pole[j] < pole[minIndex])
                    { 
                        minIndex = j;
                    }
                }

                if(i != minIndex)
                {
                    int cisloPole = pole[i];
                    pole[i] = pole[minIndex];
                    pole[minIndex] = cisloPole;
                }
            }

            return pole;
        }
    }
}