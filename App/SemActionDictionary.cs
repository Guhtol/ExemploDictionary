using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class SemActionDictionary
    {
        public void Imprimir(string valor, string tipo)
        {
            if (valor.Equals("01"))
            {
                Console.WriteLine("Impressão 01");
            }
            else if (valor.Equals("02"))
            {
                if (tipo.Equals("reduzido"))
                {

                    Console.WriteLine("Impressão 02 - reduzida");
                }
                else
                {
                    Console.WriteLine("Impressão 02");
                }
            }
            else if (valor.Equals("03"))
            {
                Console.WriteLine("Impressão 03");
            }
            else
            {
                Console.WriteLine("Impressão Padrão");
            }
        }
    }
}
