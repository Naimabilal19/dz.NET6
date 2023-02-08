using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class employee
    {
        public string FIO { get; set; }
        public static string birth { get; set; } 
        public string email { get; set; }
        public string job { get; set; }
        public string descrp { get; set; }
        public int contact { get; set; }

        public static string GetBirth()
        {
            return birth;
        }
        public static void SetBirth(string k)
        {
            birth = k;
        }
        static employee ()
            {
            Console.WriteLine("Введите дату рождения: ");
            birth = Console.ReadLine();
            }
    public void Input()
        {
            Console.WriteLine("Введите ФИО: ");
            FIO = Console.ReadLine();
            Console.WriteLine("Введите телефон: ");
            contact = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите email: ");
            email = Console.ReadLine();
            Console.WriteLine("Введите должность: ");
            job = Console.ReadLine();
            Console.WriteLine("Введите описание служебных обязаностей: ");
            descrp = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($"ФИО: { FIO}\n датa рождения: {birth}\n  телефон: {contact}\n email: {email}\n должность: {job}\n описание служебных обязаностей:{descrp}");
        }
        public override string ToString()
        {
            return $"ФИО: { FIO}\n датa рождения: {birth}\n  телефон: {contact}\n email: {email}\n должность: {job}\n описание служебных обязаностей:{descrp}";
        }
    }
}
