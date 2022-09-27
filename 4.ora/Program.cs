using System;

namespace _4.ora
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            /*
            #region metodusok
            MetodusVoid();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Adj meg egy számot");
                int szam = int.Parse(Console.ReadLine());
                Console.WriteLine( MetodusInt(szam) );

            }
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Adj meg egy szót");
                string szavacska = Console.ReadLine();
                Console.WriteLine(MethodusString(szavacska));

            }
            Console.WriteLine("\n\nVége...\n\n");

            #endregion

            */
            #region Feladatok


            Console.WriteLine(  TombKiiras(  TombGeneralas(5)  )  ); 


            #endregion


            Console.ReadKey();

        }

        static int[] TombGeneralas(int db)
        {
            int[] tomb = new int[db];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(0, 100);
            }
            return tomb;
        }

        static string TombKiiras(int[] szamok)
        {
            string szoveg = "";
            for (int i = 0; i < szamok.Length; i++)
            {
                szoveg+=$"{szamok[i]},";
            }
            return szoveg;
        }



        public static void MetodusVoid()
        {
            Console.WriteLine("Ez egy metódus.");
        }

        public static int MetodusInt(int a)
        {
            int b = 2 * a;
            int aaaahj = a + b;
            return aaaahj;
        }
        public static string MethodusString(string szo)
        {
            string allat = szo;
            return allat.ToLower();

        }
    }
}
