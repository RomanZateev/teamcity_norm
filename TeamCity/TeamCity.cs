using System;

namespace TeamCity
{
    public class TeamCity
    {
        public TeamCity() { }

        private static int size;

        public int Size
        {
            get => size;
            set => size = value;
        }

        public static int count(int a, int b)
        {
            return a + b;
        }

        public void write()
        {
            size = 10;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("res: " + count(i, i + 1).ToString());
            }
            Console.ReadKey();
        }

        private static int numerator;

        public int Numerator
        {
            get => numerator;
            set => numerator = value;
        }

        private static int denominator;

        public int Denominator
        {
            get => denominator;
            set => denominator = value;
        }

        public double devide()
        {
            return (double) Numerator / Denominator;
        }
    }
}
