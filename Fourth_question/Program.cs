using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_question
{
    class Program
    {
        static void Main(string[] args)
        {
              int[] numbers = new int[6]; // آرایه برای ذخیره ۶ عدد

              Console.WriteLine("Enter 6 numbers:");

              // دریافت ۶ عدد از کاربر
              for (int i = 0; i < numbers.Length; i++)
              {
                  Console.Write("Number {0}: ", i + 1);
                  numbers[i] = int.Parse(Console.ReadLine());
              }

              Console.WriteLine("\nFactorials of entered numbers:");

              // محاسبه و نمایش فاکتوریل هر عدد
              for (int i = 0; i < numbers.Length; i++)
              {
                  Console.WriteLine("Factorial of {0} = {1}", numbers[i], Factorial(numbers[i]));
              }
              Console.ReadKey();
        }

        // متد محاسبه فاکتوریل
        static long Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1); // فراخوانی بازگشتی
        }
    }
}
