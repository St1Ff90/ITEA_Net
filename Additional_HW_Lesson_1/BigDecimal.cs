using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Additional_HW_Lesson_1
{

    public struct BigDecimal : IComparable
    {
        public string Integer { get; set; }
        public string Remainder { get; set; }

        public BigDecimal(string _integer, string _remainder) : this()
        {
            Integer = _integer;
            Remainder = _remainder;
        }

        public static implicit operator BigDecimal(string a)
        {
            string integer = a;
            string remainder = "";

            if (a.Contains("."))
            {
                integer = a.Substring(0, a.IndexOf("."));
                remainder = a.Substring(integer.Length + 1);
            }

            return new BigDecimal(integer, remainder);
        }

        public static BigDecimal operator + (BigDecimal a, BigDecimal b)
        {
            BigDecimal bigDecimal = new BigDecimal();
            
            if (a.Remainder.Length > b.Remainder.Length)
            {
                for (int i = 0, repeat = a.Remainder.Length - b.Remainder.Length; i < repeat; i++)
                {
                    b.Remainder += 0;
                }
            }
            else if (a.Remainder.Length < b.Remainder.Length)
            {
                for (int i = 0, repeat = b.Remainder.Length - a.Remainder.Length; i < repeat; i++)
                {
                    a.Remainder += 0;
                }
            }

            string integerA = new string(a.Integer.Reverse().ToArray());
            string integerB = new string(b.Integer.Reverse().ToArray());

            if (a.Integer.Length < b.Integer.Length)
            {
                for (int i = 0, repeat = b.Integer.Length - a.Integer.Length; i < repeat; i++)
                {
                    integerA += 0;
                }
            }
            else if (a.Integer.Length > b.Integer.Length)
            {
                for (int i = 0, repeat = a.Integer.Length - b.Integer.Length; i < repeat; i++)
                {
                    integerB += 0;
                }
            }

            string reminderA = new string(a.Remainder.Reverse().ToArray());
            string reminderB = new string(b.Remainder.Reverse().ToArray());
            

            int change = 0;

            for (int i = 0; i < reminderA.Length; i++)
            {
                    int result = reminderA[i] - '0' + reminderB[i] - '0' + change;
                    change = 0;
                    if (result > 9)
                    {
                        change = 1;
                        result %= 10;
                    }
                    bigDecimal.Remainder += result;
            }

            for (int i = 0; i < integerA.Length; i++)
            {
                int result = integerA[i] - '0' + integerB[i] - '0' + change;
                change = 0;
                if (result > 9)
                {
                    change = 1;
                    result %= 10;
                }
                bigDecimal.Integer += result;
            }

            if(change > 0)
            {
                bigDecimal.Integer += 1;
            }

            bigDecimal.Remainder = new string(bigDecimal.Remainder.Reverse().ToArray());
            bigDecimal.Integer = new string(bigDecimal.Integer.Reverse().ToArray());

            return bigDecimal;
        }



    public int CompareTo(object obj)
    {
        throw new NotImplementedException();
    }
}


    //public struct BigDecimal
    //{
    //    public BigInteger Integer { get; set; }
    //    public BigInteger Scale { get; set; }

    //    public BigDecimal(BigInteger integer, BigInteger scale) : this()
    //    {
    //        Integer = integer;
    //        Scale = scale;
    //        while (Scale > 0 && Integer % 10 == 0)
    //        {
    //            Integer /= 10;
    //            Scale -= 1;
    //        }
    //    }

    //    public static implicit operator BigDecimal(decimal a)
    //    {
    //        BigInteger integer = (BigInteger)a;
    //        BigInteger scale = 0;
    //        decimal scaleFactor = 1m;
    //        while ((decimal)integer != a * scaleFactor)
    //        {
    //            scale += 1;
    //            scaleFactor *= 10;
    //            integer = (BigInteger)(a * scaleFactor);
    //        }
    //        return new BigDecimal(integer, scale);
    //    }

    //    public static BigDecimal operator *(BigDecimal a, BigDecimal b)
    //    {
    //        return new BigDecimal(a.Integer * b.Integer, a.Scale + b.Scale);
    //    }

    //    public override string ToString()
    //    {
    //        string s = Integer.ToString();
    //        if (Scale != 0)
    //        {
    //            if (Scale > Int32.MaxValue) return "[Undisplayable]";
    //            int decimalPos = s.Length - (int)Scale;
    //            s = s.Insert(decimalPos, decimalPos == 0 ? "0." : ".");
    //        }
    //        return s;
    //    }
    //}
}

