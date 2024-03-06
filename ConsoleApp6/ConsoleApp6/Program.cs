using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        public static int[] povoleneMince = {1, 2, 5, 10, 20, 50 };

        public static string[] nazev = {"0", "černá káva", "káva s mlékem", "káva irská", "čaj černý","čaj ovocný"};
        public static int[] cena = {0, 12, 20, 30, 10, 15};

        static void Main(string[] args)
        {
            int index = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                VypisMenu();

                Console.Write("Vyberte nápoj: ");
                if (!int.TryParse(Console.ReadLine(), out index))
                {
                    Console.WriteLine("Chyba: zadejte číslo");
                }else
                {
                    if (index < 0 || index > nazev.Length)
                    {
                        Console.WriteLine("Chyba: musíte zadat číslo v rozmezí 0 až " + (nazev.Length - 1));
                    }else if(index == 0)
                    {
                        Console.WriteLine("Nashledanou..");
                        return;
                    }else
                    {
                        break;
                    }
                }
            }while (true);

            int vratka = platba(cena[index]);
            if(vratka < 0)
            {
                Console.WriteLine("Připravuji nápoj: " + nazev[index]);

                VypocetMinci(Math.Abs(vratka));
            }else
            {
                Console.WriteLine("Připravuji nápoj: " + nazev[index]);
            }

            Console.WriteLine("Ať nápoj chutná!");
            Main(args);
        }

        static int platba(int cena)
        {
            VypisPovoleneMince();

            int dluh = cena;
            do
            {
                int vlozeno = 0;
                Console.Write($"Zadejte minci (zbývá {dluh} Kč): ");
                if (int.TryParse(Console.ReadLine(), out vlozeno))
                {
                    for(int i = 0; i < povoleneMince.Length; i++)
                    {
                        if(vlozeno == povoleneMince[i])
                        {
                            dluh -= vlozeno;
                            break;
                        }
                    }
                }
            }while (dluh > 0);
            Console.WriteLine("Děkuji");
            return dluh;
        }

        static void VypocetMinci(int celkovyPreplatek)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            do
            {
                for (int i = povoleneMince.Length - 1; i >= 0; i--)
                {
                    int povolenaMince = povoleneMince[i];
                    if(celkovyPreplatek >= povolenaMince)
                    {
                        celkovyPreplatek -= povolenaMince;
                        if(dic.ContainsKey(povolenaMince))
                        {
                            dic[povolenaMince]++;
                            break;
                        }else
                        {
                            dic.Add(povolenaMince, 1);
                            break;
                        }
                    }
                }
            } while (celkovyPreplatek != 0);

            Console.WriteLine("Vracím mince: ");
            for(int i = povoleneMince.Length - 1; i >= 0; i--)
            {
                if (dic.ContainsKey(povoleneMince[i]))
                {
                    Console.WriteLine(" - " + povoleneMince[i] + ": " + dic[povoleneMince[i]] + "x");
                }
            }
        }

        static void VypisPovoleneMince()
        {
            Console.WriteLine("Zaplaťte nápoj");
            Console.Write("Povolené mince: ");
            for (int i = 0; i < povoleneMince.Length; i++)
            {
                Console.Write(povoleneMince[i] + " ");
            }
            Console.WriteLine();
        }

        static void VypisMenu()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("**       Vyberte nápoj:      **");

            for (int i = 1; i < nazev.Length; i++)
            {
                Console.Write("**  ");
                string text = nazev[i] + "              ";
                text = text.Substring(0, 14);
                Console.Write(i + " .. " + text + cena[i] + " Kč");
                Console.WriteLine(" **");
            }
            Console.WriteLine("**  0 .. odejít od automatu  **");
            Console.WriteLine("*******************************");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
