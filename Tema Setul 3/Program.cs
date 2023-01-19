using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Setul_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar de 1 la 31 pentru selectarea unei probleme: ");
            switch (Console.ReadLine())
            {
                case "1":
                    P1();
                    break;
                case "2":
                    P2();
                    break;
                case "3":
                    P3();
                    break;
                case "4":
                    P4();
                    break;
                case "5":
                    P5();
                    break;
                case "6":
                    P6();
                    break;
                case "7":
                    P7();
                    break;
                case "8":
                    P8();
                    break;
                case "9":
                    P9();
                    break;
                case "10":
                    P10();
                    break;
                case "11":
                    P11();
                    break;
                case "12":
                    P12();
                    break;
                case "13":
                    P13();
                    break;
                case "14":
                    P14();
                    break;
                case "15":
                    P15();
                    break;
                case "16":
                    P16();
                    break;
                case "17":
                    P17();
                    break;
                case "18":
                    P18();
                    break;
                case "19":
                    P19();
                    break;
                case "20":
                    P20();
                    break;
                case "21":
                    P21();
                    break;
                case "22":
                    P22();
                    break;
                case "23":
                    P23();
                    break;
                case "24":
                    P24();
                    break;
                case "25":
                    P25();
                    break;
                case "26":
                    P26();
                    break;
                case "27":
                    P27();
                    break;
                case "28":
                    P28();
                    break;
                case "29":
                    P29();
                    break;
                case "30":
                    P30();
                    break;
                case "31":
                    P31();
                    break;


            }
        }

        private static void P1()
        {
            int suma = 0;

            Console.Write("Problema 1\nCate numere doriti sa introduceti: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti cele " + n + " numere separate cu space intre ele: ");
            
            string[] tokens = Console.ReadLine().Split(' ');
            int[] numere = new int[n];

            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = int.Parse(tokens[i]);
                suma += numere[i];
            }

            Console.WriteLine("Suma elementelor din vector este " + suma);
            Console.ReadKey();
        }
        private static void P2()
        {
            Console.Write("Problema 2\nIntroduceti lungimea vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti o valoare k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti cele " + n + " numere: ");
            int[] vector = new int[n];
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            int pozitia = -1;

            for (int i = 0; i < n && pozitia == -1; i++)
            {
                if (vector[i] == k)
                    pozitia = i;
            }

            Console.WriteLine("Pozitia lui k este " + pozitia);

        Console.ReadKey();
        }
        private static void P3()
        {
            Console.Write("Problema 3\nIntroduceti lungimea vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int min = Int32.MaxValue;
            int max = Int32.MinValue;

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            int minI = -1, maxI = -1;

            for (int i = 0; i < n / 2; i++)
            {
                if (vector[i] > max)
                {
                    maxI = i;
                    max = vector[i];
                }
                if (vector[i] < min)
                {
                    minI = i;
                    min = vector[i];
                }
                if (vector[n - (i + 1)] > max)
                {
                    maxI = n - (i + 1);
                    max = vector[n - (i + 1)];
                }
                if (vector[n - (i + 1)] < min)
                {
                    minI = n - (i + 1);
                    min = vector[n - (i + 1)];
                }
            }
            Console.ReadKey();
        }
        private static void P4()
        {
            Console.Write("Problema 3\nIntroduceti lungimea vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;

            Console.WriteLine("Introduceti cele " + n + " numere: ");
            int[] vector = new int[n];
            for(int i = 0; i < n; i++)
            {
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            int nrMax = 1, nrMin = 1;

            for (int i = 0; i < n; i++)
            {
                if (vector[i] == max)
                    nrMax++;
                else if (vector[i] > max)
                {
                    nrMax = 1;
                    max = vector[i];
                }

                if (vector[i] == min)
                    nrMin++;
                else if (vector[i] < min)
                {
                    nrMin = 1;
                    min = vector[i];
                }
            }
            if (nrMin == 1)
            {
                Console.WriteLine($"Cel mai mic element din vector este {min} si apare o data,\nCel mai mare element este {max} si apare de {nrMax} ori.");
            }
            else if (nrMax == 1)
            {
                Console.WriteLine($"Cel mai mic element din vector este {min} si apare de {nrMin} ori,\nCel mai mare element este {max} si apare o data.");
            }
            else
            {
                Console.WriteLine($"Cel mai mic element din vector este {min} si apare de {nrMin} ori,\nCel mai mare element este {max} si apare de {nrMax} ori.");
            }
            Console.ReadKey();
        }
        private static void P5()
        {
            Console.Write("Problema 5\nIntroduceti lungimea vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti o valoare e: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti o pozitie k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti cele " + n + " numere: ");
            int[] vector = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }         

            vector[k] = e;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Pozitia{i}:{vector[i]}");
            }
            Console.ReadKey();
        }
        private static void P6()
        {
            Console.Write("Problema 6\nIntroduceti lungimea vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti o pozitie k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti cele " + n + " numere: ");
            int[] vector = new int[n + 1];

            for(int i = 0; i < n; i++)
            {
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = k; i < n; i++)
            {
                vector[i] = vector[i + 1];
            }
            Console.WriteLine("---");
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.ReadKey();
        }
        private static void P7()
        {
            Console.Write("Problema 7\nIntroduceti lungimea vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti cele " + n + " elemente: ");
            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

          
            for (int i = 0; i < n/2; i++)
            {
                int aux = vector[i];

                vector[i] = vector[n - i - 1];
                vector[n-i- 1] = aux;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.ReadKey();
        }
        private static void P8()
        {
            Console.Write("Problema 8\nIntroduceti lungimea vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti cele " + n + " numere: ");
            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            int aux = vector[0];

            for (int i = 0; i < n-1; i++)
            {
                vector[i] = vector[i + 1];
            }

            vector[n - 1] = aux;
            Console.WriteLine("---");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.ReadKey();
        }
        private static void P9()
        {
            Console.Write("Problema 9\nIntroduceti lungimea vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti numarul rotirilor: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti cele " + n + " elemente: ");
            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            while (k > 0)
            {
                int aux = vector[0];
                for(int i = 0; i < n - 1; i++)
                {
                    vector[i] = vector[i + 1];
                }
                vector[n - 1] = aux;

                k--;
            }
            Console.WriteLine("---");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.ReadKey();
        }
        private static void P10()
        {

        }
        private static void P11()
        {

        }
        private static void P12()
        {

        }
        private static void P13()
        {

        }
        private static void P14()
        {

        }
        private static void P15()
        {
         /*   Console.Write("Problema 15\nIntroduceti lungimea vectorului:");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                    if (vector[i] == vector[j])
                    {
                        for (int k = j; k < n - 1; k++)
                            vector[k] = vector[k + 1];
                        n--;
                    }
            }
            Console.WriteLine("---");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.ReadKey();*/
                
        }
        private static void P16()
        {

        }
        private static void P17()
        {

        }
        private static void P18()
        {

        }
        private static void P19()
        {

        }
        private static void P20()
        {

        }
        private static void P21()
        {

        }
        private static void P22()
        {

        }
        private static void P23()
        {

        }
        private static void P24()
        {

        }
        private static void P25()
        {

        }
        private static void P26()
        {

        }
        private static void P27()
        {

        }
        private static void P28()
        {

        }
        private static void P29()
        {

        }
        private static void P30()
        {

        }
        private static void P31()
        {

        }
    }
}
