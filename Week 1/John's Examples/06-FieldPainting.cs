using System;

namespace Session14Kata01
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;
            int area;
            int buckets = 0;
            string color;
            double coverage;

            // [Ask] the user for the __radius__ of the circle
            Console.WriteLine("What is the radius of your circle?");
            radius = Convert.ToInt32(Console.ReadLine());
            // [Figure out] the __area__
            area = (int)(radius * radius * Math.PI);

            // [Ask] the user for the __color__ of the circle
            // [Figure out] the __coverage__ of the paint
            Console.WriteLine("What is the color of your circle?");
            color = Console.ReadLine().ToLower();
            
            if(color == "red")
            {
                buckets = (int)Math.Ceiling(area / 100.0);
            }
            if(color == "blue")
            {
                buckets = (int)Math.Ceiling(area / 120.0);
            }
            
            // [Tell] them how many __buckets__ it takes to cover the area

            Console.WriteLine("It will take " + buckets + " buckets to cover the area.");
        }
    }
}
