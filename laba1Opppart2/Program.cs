using System;

namespace laba1Opppart2
{
    class Program
    {
        static void Main(string[] args)
        {
            TTringle tringle1 = new TTringle(7, 5, 4);

            tringle1.SideC = 1;
            tringle1.SideB = 2;
            Console.WriteLine(tringle1.SideA + " " + tringle1.SideB + " " + tringle1.SideC);
        }
    }

    class TTringle
    {
        protected double lengthA;
        protected double lengthB;
        protected double lengthC;

        public TTringle()
        { }

        public TTringle(double a, double b, double c)
        {
            if (a + b >= c && b + c >= a && a + c >= b)
            {
                lengthA = a;
                lengthB = b;
                lengthC = c;
            }
            else
            {
                Console.WriteLine("Ne isnuye");
            }
        }

       
        public double SideA
        {
            get
            {
                return lengthA;
            }
            set
            {
                if (value > 0 && value + lengthB >= lengthC && value + lengthC >= lengthB && lengthB + lengthC >= value)
                {
                    lengthA = value;
                }
            }
        }
        public double SideB
        {
            get
            {
                return lengthB;
            }
            set
            {
                if (value > 0 && lengthA + value >= lengthC && lengthA + lengthC >= value && value + lengthC >= lengthA)
                {
                    lengthB = value;
                }
            }
        }
        public double SideC
        {
            get
            {
                return lengthC;
            }
            set
            {
              
                if (value > 0 && lengthA + lengthB >= value && lengthA + value >= lengthB && lengthB + value >= lengthA)
                {
                    lengthC = value;
                }
            }
        }
        public double CalculatePerimeter()
        {
            return (lengthA + lengthB + lengthC);
        }
        public double CalculateArea()
        {
            return (lengthA + lengthB + lengthC) /2  ;
        }
    }
}
