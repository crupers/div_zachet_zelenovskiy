using System;
using System.Linq;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Letters = { 'A', 'B', 'C' };
            int[] Numbers = { 1, 2, 3 };
            string[] Colors = { "зеленый", "ораньжевый" };

            var cartesain = Letters.SelectMany(l => Numbers.SelectMany(n => Colors.Select(c => new { Letter = 1, Number = n, Color = c })));
            Console.WriteLine("декартовы произведения");
            foreach(var item in cartesain)
            {
                Console.WriteLine($"буква = {item.Letter}  число= {item.Number}  цвет = {item.Color}");
            }

            Console.WriteLine("\n введите признак для группировки(Letter/Number/Color)");
            string group = Console.ReadLine();
            var grouped = cartesain.GroupBy(item => group == "Letter" ? item.Letter.ToString() : group == "Number" ? item.Number.ToString() : item.Color);
        foreach(var groups in grouped)
            {
                Console.WriteLine($"\n группа по {group} = {groups.Key}:");
                foreach(var item in groups)
                {
                    Console.WriteLine($"буква : {item.Letter} , число = {item.Number} , цвет = {item.Color}");
                }

            }
        }
    }
}
