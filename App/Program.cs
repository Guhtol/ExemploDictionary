using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var exemploSem = new SemActionDictionary();
            var exemploCom = new ComActionDictionary();
            var exemploIndexer = new ComActionDictionaryIndexer();

            OpcoesValor();
            var valor = Console.ReadLine();


            OpcoesTipo();
            var tipo = Console.ReadLine();

            exemploSem.Imprimir(valor, tipo);
            exemploCom.Imprimir(valor, tipo);
            exemploIndexer[valor](valor, tipo);

            Console.ReadKey();
        }

        static void OpcoesTipo()
        {
            Console.Clear();
            Console.WriteLine("Escolha um tipo \n");
            Console.WriteLine("total, reduzido");
        }

        static void OpcoesValor()
        {
            Console.Clear();
            Console.WriteLine("Escolha um valor \n");
            Console.WriteLine("01, 02, 03");
        }
    }
}
