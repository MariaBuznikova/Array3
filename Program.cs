using System;

namespace Массивы3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] M1 = Init();
            Vivod(M1, "first");
            int[] M2 = Init();
            Vivod(M2, "second");
            int[] MSum = Sum(M1, M2);
            if (MSum == null)
                Console.WriteLine("Массивы разной длины!");
            else
                Vivod(MSum, "Сумма массивов:");
            Mull(MSum);
            Vivod(MSum, "Умноженный массив:");
            Console.WriteLine(CommonEl(M1, M2));
            Sort(M1);
            Vivod(M1, "Отсортированный массив:");
            MaxM(M1);
            MinM(M2);
            Average(M2);
        }
        static void Vvod(int[] M)
        {
            Random r = new Random();
            for (int i = 0; i < M.Length; i++)
            {
                M[i] = r.Next(100);
            }
        }

        static void Vivod(int[] M, string msg)
        {
            if (M == null)
                return;
            else
            {
                Console.WriteLine(msg + ":");
                foreach (int el in M)
                {
                    Console.Write(el.ToString() + " ");
                }
                Console.WriteLine();
            }
        }

        static int[] Init()
        {
            int[] mas;
            Console.WriteLine("Введите количество элементов:");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 0)
            {
                mas = new int[N];
                Vvod(mas);
                return mas;
            }
            else
            {
                return null;
            }
        }

        static int[] Sum(int[] M1, int[] M2)
        {

            if (M1.Length == M2.Length)
            {
                int[] Mrez = new int[M1.Length];
                for (int i = 0; i < M1.Length; i++)
                {
                    Mrez[i] = M1[i] + M2[i];
                }
                return Mrez;
            }
            else
            {
                return null;
            }
        }

        static void Mull(int[] M)
        {
            if (M == null)
            {
                Console.WriteLine("Массив не передан!");
                return;
            }
            else
            {
                Console.WriteLine("Введите число:");
                int N = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < M.Length; i++)
                {
                    M[i] = N * M[i];
                }
            }
        }

        static string CommonEl(int[] M1, int[] M2)
        {
            //Array.IndexOf(mas, el); -1
            string rez = "";
            if (M1 == null || M2 == null)
            {
                return rez;
            }
            else
            {
                Console.WriteLine("Общие значения:");
                if (rez == "")
                {
                    Console.WriteLine("Общих значений нет");
                }
                else
                {
                    for (int i = 0; i < M1.Length; i++)
                    {
                        if (Array.IndexOf(M2, M1[i]) != -1)
                            rez = rez + M1[i].ToString() + "(М1:" + i.ToString() + ")-(M2:" + Array.IndexOf(M2, M1[i]).ToString() + ") \n";
                    }
                }
                return rez;

            }
        }

        static void Sort(int[] M)
        {
            if (M == null)
            {
                Console.WriteLine("Массив не передан!");
                return;
            }
            else
            {
               
                for (int i=0; i<M.Length - 1; i++)
                {
                    for (int j =i+1; j<M.Length; j++)
                    {
                        if (M[i]<M[j])
                        {
                            int buf = M[i];
                            M[i] = M[j];
                            M[j] = buf;
                        }
                          
                    }
                }
               
            }
        }

        static int MaxM(int[] M)
        {
            int Max = M[0];
            for ( int i=1; i<M.Length; i++)
            {
                if (M[i]>Max)
                {
                    Max = M[i];
                }
            }
            Console.WriteLine($"Max = {Max}");
            return Max;
        }

        static int MinM(int[] M)
        {
            int Min = M[0];
            for (int i = 1; i < M.Length; i++)
            {
                if (M[i] < Min)
                {
                    Min = M[i];
                }
            }
            Console.WriteLine($"Max = {Min}");
            return Min;
        }

        static double Average(int[] M)
        {
            double rez = 0;
            for(int i=0; i<M.Length; i++)
            {
                rez += M[i];
            }
            rez = rez / M.Length;
            Console.WriteLine($"Average = {rez}");
            return rez;
        }
    }
}
