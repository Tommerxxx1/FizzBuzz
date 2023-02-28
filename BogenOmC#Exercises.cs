using System;
using System.Runtime.Remoting.Messaging;

namespace ConsoleApp1
{

    internal class Program
    {
        /*
        public enum PersonKøn : int
        {
            Mand = 0,
            Kvinde = 1
        }
        */

        private static void Main(string[] args)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("da-DK");
            /*
            Console.WriteLine("Skriv noget...");
            string a = Console.ReadLine();
            Console.WriteLine("Ass bitch mofufu");
            Console.WriteLine(a + " Selv");

            int b = new int();
            Console.WriteLine(b);

            int c = 0;
            Console.WriteLine(c);
            */
            /*
            DateTime a = DateTime.Now;
            DateTime b = DateTime.Today;
            DateTime c = new DateTime(2022, 02, 08, 20, 10, 10);
            DayOfWeek d = b.DayOfWeek;
            int h = b.Year;
            DateTime e = DateTime.Today;
            DateTime f = b.AddDays(1);   
            Console.WriteLine(a.ToString("dd-MM-yyyy"));
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(h);
            Console.WriteLine(f);
            */
            /*
            string navn = "Thomas";
            int alder = 36;
            string civilStatus = "Gift";
            string a = "Dette er en meget lang ";

            Console.WriteLine($"{a}historie, men jeg hedder {navn} og jeg er født i år {DateTime.Now.Year - alder-1} ");
            */
            /*
            string a = "";
            for (int i = 0; i < 50; i++)
            {
                a = a + "*";
            }
            Console.WriteLine(a);
            */
            /*
            double asd = Math.PI;
            Console.WriteLine(asd);

            Console.WriteLine();

            if (asd ==Math.PI || Math.PI > 3)
            {
                Console.WriteLine("Correct");
            }
            */
            /*
            switch (PersonKøn.Mand)
            {
                case (PersonKøn)0:
                        Console.WriteLine("Korrekt det er en mand");
                    break;
                case (PersonKøn)1:
                    Console.WriteLine($"Korrekt det er en {PersonKøn.Kvinde}");
                    break;  
            }
            */
            /*
            Console.WriteLine($"Lad os tælle til 10");
            for (int counter = 0; counter <= 10; counter++)
            {
                if (counter == 10)
                {
                    Console.WriteLine("10.......");
                }
                else
                {
                    Console.WriteLine($"{counter} og ");
                }
                          
            }
            */
            /*
            void Tæl(int tælTil)
            {
                for (int i = 1; i < tælTil+1; i++)
                {
                    Console.WriteLine(i);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Tæl(10);
            }
            */
            /*

            MinMetode1();
            MinMetode2(4);
            MinMetode3(4,"q");
            MinMetode4(4,"q");
            MinMetode5(4,"q");
            Console.WriteLine(MinMetode6("tHOMAS")); 



        }
        static void MinMetode1()
        {
            Console.WriteLine("I min metode1");
        }

        static void MinMetode2(int q)
        {
            Console.WriteLine($"I min metode2 er parameterne: {q}");
        }

        static void MinMetode3(int q, string w)
        {           
                Console.WriteLine($"I min metode3 er parameterne: {q} & {w}");          
        }

        static void MinMetode4(int q, string w)
        {

            if (q >= 5)
            {
                Console.WriteLine($"I min metode4 er parameterne: {q} & {w}");
            }
            return;
        }

        static void MinMetode5(int q, string w)
        {
            if (q < 5)
            {
                return;
            }
            Console.WriteLine($"I min metode5 er parameterne: {q} & {w}");
        }

        static string MinMetode6 (string navn)
        {
            if (navn == null || navn == "")
                return "";

            string lille = navn.ToLower();
            string førsteBogstav = lille.Substring(0, 1).ToUpper();
            string resten = lille.Substring(1);
            return førsteBogstav + resten;
                      */

            //Fejl1();
            //Fejl2();
            //Fejl3();
            //Fejl4();

            /*
            public static void Fejl1()
            {
                string tekst = null;
            Console.WriteLine(tekst.ToUpper());
            }

            public static void Fejl2()
            {
                string indhold = System.IO.File.ReadAllText(@"c:\temp\xyz.txt");
            }

            public static void Fejl3()
            {
                checked
                {
                    byte b = byte.MaxValue;
                    b++;
                }
            }

            public static void Fejl4()
            {
                int a = 10;
                int b = 0;
                int res = a / b;
            }
            */
            /*
            string[,] skabBræt = new string[8, 8];
            skabBræt[0, 0] = "Ts";
            skabBræt[0, 1] = "Hs";
            skabBræt[0, 2] = "Ls";
            skabBræt[0, 3] = "Ds";
            skabBræt[0, 4] = "Ks";
            skabBræt[0, 5] = "Ls";
            skabBræt[0, 6] = "Hs";
            skabBræt[0, 7] = "Ts";

            for (int i = 0; i < 8; i++)
            {
                skabBræt[1, i] = "Bs";
                skabBræt[6, i] = "Bh";
                skabBræt[7, i] = skabBræt[0, i].Replace("s", "h");
            }

            for (int række = 0; række < 8; række++)
            {
                for (int kolonne = 0; kolonne < 8; kolonne++)
                {
                    Console.WriteLine(skabBræt[række, kolonne] + " ");
                }
                Console.WriteLine();
            }
            */


            /*

              public class Terning
              {
                  private int værdi;
                  private Random rnd = new Random();
                  private string[] fejlTekst =
                  {
                      "Forkert værdi",
                      "Terning må kun bruges i weekenden"
                  };




                  public void SetVærdi(int value)
                  {
                      if (this.ErWeekend())
                      {
                          throw new Exception(this.fejlTekst[1]);
                      }
                      if (value < 1 || value > 6)
                      {
                          throw new Exception(this.fejlTekst[0]);
                      }
                      this.værdi = value;
                  }
                  public int GetVærdi()
                  {
                      if (this.ErWeekend())
                      {
                          throw new Exception(this.fejlTekst[1]);
                      }
                      return this.værdi;
                  }

                  public void Ryst()
                  {
                      this.værdi = this.rnd.Next(1,7);

                  }
                  private bool ErWeekend()
                  {
                      DayOfWeek dag = DateTime.Now.DayOfWeek;
                      switch (dag) {
                      case DayOfWeek.Sunday:
                      case DayOfWeek.Saturday:
                                  return true;

                      default:    return false;
                      }
                  }
                  */

          


          
        }
    
    }

}
