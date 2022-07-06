using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolinhaProfRomulo.EscolinhaTicTic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota1, nota2, nota3;
            double soma;
            double media;
            string resultado;

            Console.WriteLine("Qual o nome do aluno?");
            nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());
            soma = nota1 + nota2 + nota3;
            media = soma / 3;
            resultado = media >= 7 ? "aprovado" : "reprovado"; 
            

            /*Console.WriteLine("O nome do aluno é " + nome);
            Console.WriteLine("A soma das notas é " + soma);
            

            if(media >= 7)
            {
                Console.WriteLine("Você foi aprovado (a)");
                
            }
            else
            
                Console.WriteLine("Você foi reprovado (a)");
            */
                Console.WriteLine($"O aluno (a) {nome} obteve média {media} e está {resultado} ");
        }
        
    }
}
        
