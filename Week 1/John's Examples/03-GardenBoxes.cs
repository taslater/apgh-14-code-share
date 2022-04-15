using System;

namespace Session14Kata01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for a length and width
            Console.WriteLine("Please enter the length of the garden box.");
            int length;
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the width of the garden box.");
            int width = Convert.ToInt32(Console.ReadLine());

            // Show the area
            Console.WriteLine("The area of your gardenbox is " + (length * width));
            // Show the perimeter
            Console.WriteLine("The perimeter of your gardenbox is " + (length * 2 + width * 2));


            int area = length * width;

            // show how many corn
            int totalCorn = area * 3 / 16;
            Console.WriteLine("The amount of corn you can plant is: " + totalCorn);
            // show how many beets
            double beetsPerSquareFoot = 9.0 / 16;
            Console.WriteLine("The amount of beets you can plant is: " + (area * beetsPerSquareFoot));
            // show how many carrots
            double carrotsPerSquareFoot = 1;
            Console.WriteLine("The amount of carrots you can plant is: " + (area * carrotsPerSquareFoot));
        }
    }
}
