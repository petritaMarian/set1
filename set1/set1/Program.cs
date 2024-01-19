namespace set1
{
    internal class Program
    {
        // #1
        static void equationDegreeI(int a, int b)
        {
            Console.WriteLine(-b / a);
        }

        // #2
        static void equationDegreeII(int a, int b, int c)
        {
            if (b * b - 4 * a * c > 0)
            {
                Console.Write($"x1 = {(-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a)}; x2 = {(-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a)}");
            }
            else if (b * b - 4 * a * c == 0) Console.Write($"x = {-b / (2 * a)}");
            else
            {
                Console.Write($"x1 = {-b / (2 * a)} + {(Math.Sqrt(-(b * b - 4 * a * c)) / (a * 2)).ToString("F")}i; x2 = {-b / (2 * a)} - {(Math.Sqrt(-(b * b - 4 * a * c)) / (a * 2)).ToString("F")}i");
            }
        }

        // #3
        static void canDivide(int n, int k)
        {
            if (n % k == 0) Console.Write($"{n} se divide cu {k}");
            else Console.Write($"{n} nu se divide cu {k}");
        }

        // #4
        static void isLeapYear(int y)
        {
            if (DateTime.IsLeapYear(y) == true) Console.Write($"{y} is a leap year");
            else Console.Write($"{y} is not a leap year");
        }

        // #5
        static void last_k_thDigit(int n, int k)
        {
            Console.Write(Math.Truncate((n % (Math.Pow(10, k))) / Math.Pow(10, k - 1)));
        }

        // #6
        static bool isTriangle(int a, int b, int c)
        {
            if (a + b > c || b + c > a || a + c > b) return true;
            return false;
        }

        // #7
        static void numSwap(ref int a, ref int b)
        {
            int value = a;
            a = b;
            b = value;
        }

        // #8
        static void numSwapNoOtherVariables(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }

        // #9
        static void div(int n)
        {
            Console.Write("1 ");
            for (int div = 2; div <= n; div += 1)
                if (n % div == 0) Console.Write($"{div} ");
        }
        
        // #10
        static bool isPrime(int n)
        {
            if (n < 2) return false;
            if (n % 2 == 0 && n != 2) return false;
            for (int div = 3; div * div <= n; div += 2)
                if (n % div == 0) return false;
            return true;
        }

        // #11
        static void numBackwards(int n)
        {
            while (n > 0)
            {
                Console.Write(n % 10);
                n /= 10;
            }
        }

        // #12
        static void nDiv(int n, int a, int b)
        {
            int numOfDiv = 0;
            for (int i = a; i <= b; i += 1)
                if (i % n == 0) numOfDiv += 1;
            Console.Write(numOfDiv);
        }

        // #13
        static void howManyLeapYears(int y1, int y2)
        {
            int LeapYears = 0;
            for (int i = y1; i <= y2; i += 1)
                if (DateTime.IsLeapYear(i) == true) LeapYears += 1;
            Console.Write(LeapYears);
        }

        // #14
        static bool isPalindrome(int n)
        {
            int pal = 0, copy = n;
            while (copy > 0) 
            {
                pal *= 10;
                pal += copy % 10;
                copy /= 10;
            }
            if (pal == n) return true;
            return false;
        }

        // #15
        static void increasingOrder(int a, int b, int c)
        {
            int[] array = new int[] {a, b, c};
            int value;
            for (int i = 0; i < 2; i += 1)
                if (array[i] > array[i + 1])
                {
                    value = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = value;
                    i -= 1;
                }
            Console.Write($"{array[0]} {array[1]} {array[2]}");
        }
        
        // #16
        static void increasingOrderNoArray(int a, int b, int c, int d, int e)
        {
            int temp;
            for (int i  = 0; i < 5; i += 1)
            {
                if (a > b) { temp = a; a = b; b = temp; }
                if (b > c) { temp = b; b = c; c = temp; }
                if (c > d) { temp = c; c = d; d = temp; }
                if (d > e) { temp = d; d = e; e = temp; }
            }
            Console.Write($"{a} {b} {c} {d} {e}");
        }

        // #17
        static void cmmdc_cmmmc(int a, int b)
        {
            int copya = a, copyb = b;
            while (a != b)
                if (a > b) a -= b;
                else b -= a;
            Console.Write($"Cel mai mare divizor comun al numerelor {copya} si {copyb} este {a}, iar cel mai mic multiplu comun este {(copya * copyb) / a}");
        }

        // #18
        static void descompunereInFactoriPrimi(int n)
        {
            int exp, div = 2;
            while (n > 1)
            {
                exp = 0;
                while (n % div == 0)
                {
                    exp += 1;
                    n /= div;
                }
                if (exp > 0) Console.Write($"{div}^{exp} x ");
                if (div == 2) div = 3;
                else div += 2;
            }
        }

        // #19
        static bool only2Digits(int n)
        {
            int lastDigit = n % 10, penultimateDigit = n % 100 / 10;
            n /= 100;
            while (n > 0)
            {
                if ((n % 10 != lastDigit) && (n % 10 != penultimateDigit)) return false;
                n /= 10;
            }
            return true;
        }

        static void Main(string[] args)
        {
            ;
        }
    }
}
