using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano_nascimento, ano_atual,idade;
            //declara as variáveis inteiro
            Console.Write("Digite o ano de seu nascimento: ");
            //Console.Write = escreva

            ano_nascimento = int.Parse(Console.ReadLine());
            //int.Parse - converte texto em numero

            Console.Write("Digite o ano atual: ");
            ano_atual = int.Parse(Console.ReadLine());
            idade = ano_atual - ano_nascimento;
            Console.Write("Sua idade é " + idade + " anos");









        }
    }
}
