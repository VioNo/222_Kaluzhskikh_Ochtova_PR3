using System;
using System.Collections.Generic;

namespace _222_Kaluzhskikh_Ochtova_PR3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Числа Фибоначчи

            int result = Fibonacci(5);
            Console.WriteLine(result);

            int Fibonacci(int n)
            {
                Console.WriteLine("The output is: ");
                int n1 = 0;
                int n2 = 1;
                int sum;

                for (int i = 2; i <= n; i++)
                {
                    sum = n1 + n2;
                    n1 = n2;
                    n2 = sum;
                }

                return n == 0 ? n1 : n2;
            }
            Console.ReadLine();

            // Галактика

            Console.WriteLine("Welcome to Galaxy News!");
            IterateThroughList();
            Console.ReadKey();

            // Буквы

            char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
            string name = "";
            int[] a = new int[10];
            for (int i = 0; i < letters.Length; i++)
            {
                name += letters[i];
                a[i] = i + 1;
                SendMessage(name, a[i]);
            }
            Console.ReadKey();
        }

        // Буквы

        static void SendMessage(string name, int msg)
        {
            Console.WriteLine("Hello, " + name + "! Count to " + msg);
        }

        // Галактика

        private static void IterateThroughList()
        {
            var theGalaxies = new List<Galaxy>
            {
                new Galaxy() { Name="Tadpole", MegaLightYears=400, GalaxyType=new GType('S')},
                new Galaxy() { Name="Pinwheel", MegaLightYears=25, GalaxyType=new GType('S')},
                new Galaxy() { Name="Cartwheel", MegaLightYears=500, GalaxyType=new GType('L')},
                new Galaxy() { Name="Small Magellanic Cloud", MegaLightYears=.2, GalaxyType=new GType('I')},
                new Galaxy() { Name="Andromeda", MegaLightYears=3, GalaxyType=new GType('S')},
                new Galaxy() { Name="Maffei 1", MegaLightYears=11, GalaxyType=new GType('E')}
            };

            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears + ",  " + theGalaxy.GalaxyType);
            }
        }
    }

    public class Galaxy
    {
        public string Name { get; set; }

        public double MegaLightYears { get; set; }
        public GType GalaxyType { get; set; }

    }

    public class GType
    {
        public GType(char type)
        {
            switch (type)
            {
                case 'S':
                    MyGType = Type.Spiral;
                    break;
                case 'E':
                    MyGType = Type.Elliptical;
                    break;
                case 'I':
                    MyGType = Type.Irregular;
                    break;
                case 'L':
                    MyGType = Type.Lenticular;
                    break;
                default:
                    break;
            }
        }
        public object MyGType { get; set; }
        private enum Type { Spiral, Elliptical, Irregular, Lenticular }
    }
}


