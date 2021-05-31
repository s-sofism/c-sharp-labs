using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Laba7
{
    class Fraction : IComparable<Fraction>, IEquatable<Fraction>, IComparer<Fraction>
    {
        private long Numerator { get; }
        private long Denominator { get; }
        ~Fraction() 
        {
        }
        public Fraction()
        {
            Denominator = 1;
            Numerator = 1;
        }
        public Fraction(long a)
        {
            Numerator = a;
            Denominator = 1;
        }
        public Fraction(long Numerator, long Denominator)
        {
            if (Denominator == 0)
            {
                throw new DivideByZeroException();
            }
            if (Denominator < 0)
            {
                Denominator = -Denominator;
                Numerator = -Numerator;
            }
            this.Numerator = Numerator / GCD(Math.Abs(Numerator), Math.Abs(Denominator));
            this.Denominator = Denominator / GCD(Math.Abs(Numerator), Math.Abs(Denominator));
        }
        public static Fraction operator +(Fraction r1, Fraction r2)
        {
            Fraction result;
            if (r1.Denominator == r2.Denominator)
                result = new Fraction(r1.Numerator + r2.Numerator, r1.Denominator);
            else
                result = new Fraction((r1.Numerator * r2.Denominator) + (r2.Numerator * r1.Denominator), r1.Denominator * r2.Denominator);
            return result;
        }
        public static Fraction operator +(Fraction r2, long a)
        {
            Fraction result;
            result = new Fraction((a * r2.Denominator) + (r2.Numerator), r2.Denominator);
            return result;
        }
        public static Fraction operator -(Fraction r1, Fraction r2)
        {
            Fraction result;
            if (r1.Denominator == r2.Denominator)
                result = new Fraction(r1.Numerator - r2.Numerator, r1.Denominator);
            else
                result = new Fraction((r1.Numerator * r2.Denominator) - (r2.Numerator * r1.Denominator), r1.Denominator * r2.Denominator);
            return result;
        }
        public static Fraction operator -(long a, Fraction r2)
        {
            Fraction result;
            result = new Fraction((a * r2.Denominator) - r2.Numerator, r2.Denominator);
            return result;
        }
        public static Fraction operator *(Fraction r1, Fraction r2)
        {
            Fraction result = new Fraction(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator);
            return result;
        }
        public static Fraction operator *(long a, Fraction r2)
        {
            Fraction result = new Fraction(a * r2.Numerator, r2.Denominator);
            return result;
        }
        public static Fraction operator /(Fraction r1, Fraction r2)
        {
            Fraction result = new Fraction(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator);
            return result;
        }
        public static Fraction operator /(long a, Fraction r2)
        {
            Fraction result = new Fraction(a * r2.Denominator, r2.Numerator);
            return result;
        }
        public static Fraction operator ++(Fraction rational)
        {
            Fraction result = new Fraction(rational.Numerator + rational.Denominator, rational.Denominator);
            return result;
        }
        public static Fraction operator --(Fraction r)
        {
            Fraction result = new Fraction(r.Numerator - r.Denominator, r.Denominator);
            return result;
        }
        public static bool operator <(Fraction r1, Fraction r2)
        {
            return r1.CompareTo(r2) == -1;
        }
        public static bool operator >(Fraction r1, Fraction r2)
        {
            return r1.CompareTo(r2) == 1;
        }
        public static bool operator >=(Fraction r1, Fraction r2)
        {
            return r1.CompareTo(r2) != -1;
        }
        public static bool operator ==(Fraction r1, Fraction r2)
        {
            return r1.Equals((object)r2);
        }
        public static bool operator !=(Fraction r1, Fraction r2)
        {
            return !(r1 == r2);
        }
        public static bool operator <=(Fraction r1, Fraction r2)
        {
            return r1.CompareTo(r2) != 1;
        }
        public static Fraction Parse(string input)
        {
            Regex regex;
            MatchCollection match;
            regex = new Regex(@"-?\d+/-?\d+");
            match = regex.Matches(input);
            if (match.Count == 1)
            {
                long num, den;
                string str = match[0].ToString();
                string[] nums = str.Split(new char[] { '/' });
                num = long.Parse(nums[0]);
                den = long.Parse(nums[1]);
                return new Fraction(num, den);
            }
            regex = new Regex(@"-?\d+\,\d+");
            match = regex.Matches(input);
            if (match.Count == 1)
            {
                long num, den;
                string str = match[0].ToString();
                string[] nums = str.Split(new char[] { ',' });
                num = long.Parse(nums[0]);
                den = 1;
                for (int i = 0; i < nums[1].Length; i++)
                {
                    checked
                    {
                        num *= 10;
                        den *= 10;
                    }
                    num += nums[1][i] - 48;
                }
                return new Fraction(num, den);
            }
            regex = new Regex(@"-?\d+\.\d+");
            match = regex.Matches(input);
            if (match.Count == 1)
            {
                long num, den;
                string str = match[0].ToString();
                string[] nums = str.Split(new char[] { '.' });
                num = long.Parse(nums[0]);
                den = 1;
                for (int i = 0; i < nums[1].Length; i++)
                {
                    checked
                    {
                        num *= 10;
                        den *= 10;
                    }
                    num += nums[1][i] - 48;
                }
                return new Fraction(num, den);
            }
            regex = new Regex(@"-?\d+");
            match = regex.Matches(input);
            if (match.Count == 1)
            {
                long num;
                num = long.Parse(match[0].Value);
                return new Fraction(num, 1);
            }
            return null;
        }
        private long GCD(long a, long b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                while (b != 0)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }
                return a;
            }
        }
        public int Compare(Fraction r1, Fraction r2)
        {
            if (r1 != null && r2 != null)
            {
                long a, b;
                checked
                {
                    a = r1.Numerator * r2.Denominator;
                    b = r1.Denominator * r2.Numerator;
                }
                return a.CompareTo(b);
            }
            else
            {
                throw new ArgumentException("не рациональное число");
            }
        }
        public int CompareTo(Fraction obj)
        {
            return this.Compare(this, obj);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Fraction objAsRN = obj as Fraction;
            if (objAsRN == null)
            {
                return false;
            }
            else
            {
                return Equals(objAsRN);
            }
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator / Denominator);
        }
        public bool Equals(Fraction obj)
        {
            if (obj == null)
            {
                return false;
            }
            return Numerator * obj.Denominator == obj.Numerator * Denominator;
        }
        public override string ToString()
        {
            return ToString("incorrect");
        }
        public string ToString(string type)
        {
            switch (type)
            {
                case "incorrect":
                    {
                        if (Denominator != 1 && Numerator != 0)
                        {
                            return Numerator + "/" + Denominator;
                        }
                        else
                        {
                            return Numerator.ToString();
                        }
                    }
                case "correct":
                    {
                        if (Denominator != 1 && Numerator != 0)
                        {
                            if (Math.Abs(Numerator / Denominator) >= 1)
                            {
                                return Numerator / Denominator + "+" + Numerator % Denominator + "/" + Denominator;
                            }
                            else
                            {
                                return Numerator + "/" + Denominator;
                            }
                        }
                        else
                        {
                            return Numerator.ToString();
                        }
                    }
                case "long":
                    {
                        if (Denominator != 1 && Numerator != 0)
                        {
                            return (Numerator / Denominator).ToString();
                        }
                        else
                        {
                            return Numerator.ToString();
                        }
                    }
                case "float":
                    {
                        if (Denominator != 1 && Numerator != 0)
                        {
                            return (Numerator / (float)Denominator).ToString();
                        }
                        else
                        {
                            return Numerator.ToString();
                        }
                    }
                case "double":
                    {
                        if (Denominator != 1 && Numerator != 0)
                        {
                            return (Numerator / (double)Denominator).ToString();
                        }
                        else
                        {
                            return Numerator.ToString();
                        }
                    }
                case "decimal":
                    {
                        if (Denominator != 1 && Numerator != 0)
                        {
                            return (Numerator / (decimal)Denominator).ToString();
                        }
                        else
                        {
                            return Numerator.ToString();
                        }
                    }
                default:
                    {
                        return this.ToString("correct");
                    }
            }
        }
        public static explicit operator long(Fraction a)
        {
            checked
            {
                long ans = a.Numerator / a.Denominator;
                if ((Math.Abs(a.Numerator) % a.Denominator) * 2 >= a.Denominator)
                {
                    ans += a.Numerator / Math.Abs(a.Numerator);
                }
                return ans;
            }
        }
        public static explicit operator double(Fraction a)
        {
            return ((double)a.Numerator) / a.Denominator;
        }
        public static explicit operator decimal(Fraction a)
        {
            return ((decimal)a.Numerator) / a.Denominator;
        }
    }
}