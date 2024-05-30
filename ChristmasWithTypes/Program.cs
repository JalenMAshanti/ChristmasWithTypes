using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.Day.Thursday;

            //Fixed: Santas name
            xmas.Santa = "Kris Kringle";

            //Fixed: Please get me a true coders hoodie
            xmas.Presents =  new string[3]{"TrueCoders Swag", "New Car", "MacBook"}; 

            //Fixed: Thats a pretty tall tree
            xmas.TreeHeight = 10;

            Console.WriteLine($"This year christmas falls on {xmasDay} \n");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high \n");
            Console.WriteLine("Here are the presents we would like:");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            }

            Console.WriteLine($"\n We like to call Santa, {xmas.Santa}");
        }
    }
}
