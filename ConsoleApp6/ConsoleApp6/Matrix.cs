using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
   public class Matrix
    {
         int[,] m = new int[4,4];
      
        public void InputMatrix()
        {
            Random r = new Random();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = r.Next(1, 100);
                }
            }   
        }

        public int Max(int max=0)
        {
            max=m.Cast<int>().Max();
            return max;
        }
        public int Min(int min=0)
        {
            min = m.Cast<int>().Min();
            return min;
        }
        public override string ToString()
        {
            string s = null;
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    s += m[i, j] + " ";
            return s;
        }
        public void Print()
        {
            string s = this.ToString();
            Console.WriteLine( s);

        }

    }
}
