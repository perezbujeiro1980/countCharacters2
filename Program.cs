using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace countCharacter2
{
    class Program
    {
        static void Main(string[] args)
        {

            string cadena ="asdadkl2o90asdkasdokkzxcklzxce23okasdX";
            char caracter = 'X';
            int n=0;

            /*
            foreach (var c in cadena)

            {
                if (c == caracter)
                    n++;
            }
            
            Console.WriteLine("Se repite la letra {0} {1} veces ", caracter, n);
            Console.ReadLine();
             
            */

            n = cadena.Where(c => c == caracter).Count();

            Console.Write("El caracter {0} se encuentra {1} veces", caracter, n);
            Console.ReadKey();



        }
    }
}
