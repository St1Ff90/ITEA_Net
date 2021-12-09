using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Additional_HW_Lesson_1
{
    public struct BigDecimal : IComparable
    {
        public string Integer { get; set; }
        public string Scale { get; set; }

        public BigDecimal(string _integer, string _scale) : this()
        {
            Integer = _integer;
            Scale = _scale;
        }

        public int CompareTo(object obj)
        {

            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                sum = (int)Math.Pow(i, (1/i));
            }


            throw new NotImplementedException();

        }


    }
}

