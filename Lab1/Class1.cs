using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt04Math
{
    public class PraktMath
    {
        public static double For1(int n, int k)
        {
            double dob = 1;
            for (int i = n; i <= k; i++)
            {
                dob *= i;
            }

            return dob;
        }

        public static double For2(int n)
        {
            double d = 0;
            for (int i = 1; i <= n; i++)
                d += 1.0 / i;

            return d;
        }
        public static double For3(double l, int h)
        {
            double j;
            j = l;
            for (int i = 1; i < h; i++)
            {
                l *= j;

            }
            return l;

        }
        public static double For4(int l, int h)
        {
            double sum = 0;
            {
                for (int i = l; i <= h; i++)
                    sum += Math.Pow(i, 2);
            }
            return sum;
        }
        public static int fakt(int g)
        {
            if (g == 1) return 1;
            return g * fakt(g - 1);
        }
        public static double For5(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += fakt(i);

            }

            return sum;
        }
        public static double While1(int n)
        {
            double l = 0, h = 0, b = 0;
            while (l <= n)
            {
                b -= b;
                while (b <= n)
                {

                    if (l == b + 1)
                        h += Math.Pow(l, n - b);
                    b++;
                }
                l++;
            }
            return h;
        }
        public static double While2(int n)
        {
            int k = 0;
            while (true)
            {

                if (n < Math.Pow(3, k))
                {

                    break;
                }
                k++;
            }
            return k;
        }
        public static double While3(double j, out double d)
        {
            double b = 10, g = 0, n = 0;
            while (true)
            {
                g++;
                d = b += (b * j) / 100;
                if (b <= 200) n++;
                if (b > 200)
                {
                    n++;
                    break;
                }
            }
            return n;
        }
        public static int DoW(int j)
        {
            int suma = 0;
            do
            {

                suma += j % 10;
                j /= 10;

            } while (j != 0);
            return suma;
        }
        public static double Viet(double j, int g)
        {
            int b = 0;
            double n = Math.Sqrt(1.0 / 2), a = 1;
            while (b < g)
            {
                b++;
                a *= n;
                n = Math.Sqrt(1.0 / 2 + 1.0 / 2 * n);
            }
            return a;
        }
        public static double John(double z, int p)
        {
            double i = 1, g = 3, k = 1, d, j = 2;
            int c = 0;
            while (c < p)
            {

                d = k * g / (j * j);
                k += 2; g += 2; j += 2;
                i *= d;
                c++;


            }
            return i;
        }
        public static double Lord(double z, int p)
        {
            double kk = 0, bb, b2 = 3, c2 = 5;
            int m = 0;
            while (m < p)
            {
                m++;
                bb = 2 + b2 * b2 / (c2 * c2);
                kk = 1 + 1 / (2 + b2 * b2 / (c2 * c2));
                b2 += 2; c2 += 2;


            }
            return kk;

        }
        public static double Lei(double z, int j)
        {
            double a1 = 1, b1 = 3, g1 = 1;
            int p = 0;
            while (p<j)
            {
                p++;
                if (p % 2 != 0)
                    g1 -= a1 / b1;
                if (p % 2 == 0)
                    g1 += a1 / b1;
                b1 += 2;
                
            }
            return g1;

        }
    }
}
