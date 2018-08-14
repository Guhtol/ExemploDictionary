using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class ComActionDictionaryIndexer
    {
        private readonly Dictionary<string, Action<string, string>> _dictionary;
        public ComActionDictionaryIndexer()
        {
            _dictionary = new Dictionary<string, Action<string, string>>
            {
                {"01",PrimeiroRelatorio  },
                {"02", SegundoRelatorio },
                {"03", TerceiroRelatorio }
            };
        }

        public Action<string, string> this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

        public void Imprimir(string valor, string tipo)
        {
            _dictionary[valor](valor, tipo);
        }

        void PrimeiroRelatorio(string valor, string tipo)
        {
            Console.WriteLine("Impressão 01");
        }

        void SegundoRelatorio(string valor, string tipo)
        {
            if (tipo.Equals("reduzido"))
            {
                Console.WriteLine("Impressão 02 - reduzido");
                return;
            }

            Console.WriteLine("Impressão 02");
        }

        void TerceiroRelatorio(string valor, string tipo)
        {
            Console.WriteLine("Impressão 03");
        }
    }
}
