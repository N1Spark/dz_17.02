using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._02
{
        class Program
        {
            #region 1
            public static string EvemNum(int[] a)
            {
                string buf = "";
                for (int i = 0; i < a.Length; i++)
                    if (a[i] % 2 == 0 && a[i] != 0)
                        buf += a[i] + " ";
                return buf;
            }
            public static string OddNum(int[] a)
            {
                string buf = "";
                for (int i = 0; i < a.Length; i++)
                    if (a[i] % 2 != 0)
                        buf += a[i] + " ";
                return buf;
            }
            public static string PrimeNum(int[] a)
            {
                string buf = "";
                for (int i = 0; i < a.Length; i++)
                    if ((a[i] % 2 != 0 && a[i] % 3 != 0) || a[i] == 2 || a[i] == 3)
                        buf += a[i] + " ";
                return buf;
            }
            public static string FibNum(int[] a)
            {
                string buf = "";
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] <= 2) buf += 1 + " ";
                    int x = 1;
                    int y = 1;
                    int ans = 0;
                    for (int j = 3; j <= a[i]; j++)
                    {
                        ans = x + y;
                        x = y;
                        y = ans;
                    }
                    buf += ans + " ";
                }
                return buf;
            }
            public delegate string ArrNum(int[] a);
            #endregion
            #region 2
            public static string CurTime()
            {
                return DateTime.Now.ToString();
            }
            public static string CurDate()
            {
                return DateTime.Today.ToString();
            }
            public static string CurDay()
            {
                DateTime dt = DateTime.Now;

                return dt.DayOfWeek.ToString();
            }
            public delegate string CurTimeFunc();


            public static int S_Triangle(int width, int height)
            {
                return ((width * height) / 2);
            }
            public static int S_Rectangle(int width, int height)
            {
                return width * height;
            }
            public delegate int Square(int w, int h);

            #endregion
            static void Main(string[] args)
            {
                int[] buf = new int[6] { 1, 2, 3, 4, 5, 7 };
                ArrNum arr_func = new ArrNum(EvemNum);
                arr_func += OddNum;
                arr_func += PrimeNum;
                arr_func += FibNum;
                foreach (ArrNum item in arr_func.GetInvocationList())
                    Console.WriteLine(item(buf) + "\n");
                CurTimeFunc time = new CurTimeFunc(CurDate);
                time += CurDay;
                time += CurTime;
                foreach (CurTimeFunc item in time.GetInvocationList())
                    Console.WriteLine(item() + "\n");
            }
        }
}
