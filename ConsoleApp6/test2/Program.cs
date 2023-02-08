using ConsoleApp6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region задание 1
            /*employee e = new employee();
            e.Input();
            Console.WriteLine();

            e.Print();
            Console.WriteLine();

            e.FIO = "Naima Bilal";
            e.email = "bilalnaima1911@gmail.com";
            e.job = "Developer";
            e.descrp = "Codding";
            e.contact = 0934561234;


            string w = e.ToString();
            Console.WriteLine(w);*/
            #endregion

            Console.WriteLine("---------------------------------");

            #region задание 2
            /*Plane p = new Plane();
            p.Input();
            Console.WriteLine();

            p.Print();
            Console.WriteLine();

            p.name = "АНТ-1";
            p.namepr = "Андре́й Никола́евич Ту́полев";
            p.type = "лёгкий самолёт смешанной конструкции";
            
            string f = p.ToString();
            Console.WriteLine(f);*/
            #endregion
            Console.WriteLine("---------------------------------");

            #region задание 3
            Matrix x = new Matrix();
            x.InputMatrix();
            
            Console.WriteLine();
            string m = x.ToString();
            Console.WriteLine();
            Console.WriteLine(m);
            x.Max();
            x.Min();
            #endregion
        }
    }
}
