using System;

namespace Additional_HW_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BigDecimal bd1 = new BigDecimal();
            BigDecimal bd2 = new BigDecimal();

            bd1 = "9999999999999.999999999999999999999999999";
            bd2 = "999999999999999999999999999.99";
            Console.WriteLine((bd1 + bd2).ToString());

        }
    }
}
