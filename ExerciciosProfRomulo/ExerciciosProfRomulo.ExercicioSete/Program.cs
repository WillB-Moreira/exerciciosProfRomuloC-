using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.ExercicioSete
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            
   
            int i = 100;
            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.ReadKey();

            */

            
           
            public static int fatorial(int numero) {
                Console.WriteLine("Digite um número inteiro qualquer");
                int resultado = 1;
                for (int i = 0; i < numero; i--)
                {
                    resultado = resultado * numero;
                }
                return resultado;
            Console.ReadKey();
            }
            
            }
            
        }

    

