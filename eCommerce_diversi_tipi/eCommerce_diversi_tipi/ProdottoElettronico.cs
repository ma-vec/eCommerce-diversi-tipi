using eCommerce;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace eCommerce_diversi_tipi
{
    internal class ProdottoElettronico : Prodotto
    {
        private string dataProduzione;
        public string DataProduzione
        {
            get { return dataProduzione; }
        }

        private string categoria;
        public string Categoria
        {
            get { return categoria; }
        }

        

        public ProdottoElettronico(string dataProduzione, string categoria, string marca, string modello, string identificativo, double prezzo) : base(marca, modello, identificativo, prezzo) // chiamata al costruttore della classe base
        {
            this.dataProduzione = dataProduzione;
            this.categoria = categoria;
        }
    }

}
