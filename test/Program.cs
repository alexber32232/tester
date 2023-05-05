using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inp num ");
        }

        static int[] InitMass()
        {
            Random r = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = r.Next(-50, 50);
            }
            return mass;
        }
        static int Check(int[] mass, int user)
        {
            int count = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < user)
                    count++;
            }
            return count;
        }

    }

    




}
