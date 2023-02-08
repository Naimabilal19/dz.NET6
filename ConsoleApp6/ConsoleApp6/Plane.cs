using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Plane
    {
        public string name { get; set; }
        public string namepr { get; set; }
        public static int year { get; set; }
        public string type { get; set; }

        public static int GetYear()
        {
            return year;
        }
        public static void SetYear(int k)
        {
            year = k;
        }
        static Plane()
        {
            Console.WriteLine("Введите год выпуска: ");
            year = Convert.ToInt32(Console.ReadLine());
        }
        public void Input()
        {
            Console.WriteLine("Введите название самолета: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите название производителя самолета: ");
            namepr = Console.ReadLine();
            Console.WriteLine("Введите тип самолета: ");
            type = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($"название самолета: {name}\n название производителя самолета: {namepr}\n  тип самолета {type}\nГод выпуска: {year}");
        }
        public override string ToString()
        {
            return $"название самолета: {name}\nназвание производителя самолета: {namepr}\nтип самолета: {type}\nГод выпуска: {year}";
        }
    }
}
