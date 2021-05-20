using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCambio.Model
{
    /// <summary>
    /// cria um objeto de modelo 
    /// com gets e sets
    /// </summary>
    class TransacaoModel
    {
        private Int32 id;
        private Int32 idMoedaOrigem;
        private Int32 idMoedaDestino;
        private Int32 idClient;
        private string data;
        private string valorOriginal;
        private string valorConvertido;
        private string taxaCobrada;

        public int Id { get => id; set => id = value; }
        public int IdMoedaOrigem { get => idMoedaOrigem; set => idMoedaOrigem = value; }
        public int IdMoedaDestino { get => idMoedaDestino; set => idMoedaDestino = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public string Data { get => data; set => data = value; }
        public string ValorOriginal { get => valorOriginal; set => valorOriginal = value; }
        public string ValorConvertido { get => valorConvertido; set => valorConvertido = value; }
        public string TaxaCobrada { get => taxaCobrada; set => taxaCobrada = value; }
    }
}
