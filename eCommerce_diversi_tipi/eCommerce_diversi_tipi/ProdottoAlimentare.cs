using eCommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace eCommerce_diversi_tipi
{
    internal class ProdottoAlimentare : Prodotto
    {
        private string scadenza;
        public string Scadenza
        {
            get { return scadenza; }
        }

        private string categoria;
        public string Categoria
        {
            get { return categoria; } 
        }

        public void ApplicaSconto(double sconto)
        {
            Prezzo *= 1-(sconto/100);
        }

        public ProdottoAlimentare(string scadenza, string categoria, string marca, string modello, string identificativo, double prezzo) : base(marca, modello, identificativo, prezzo) // chiamata al costruttore della classe base
        {
            this.scadenza = scadenza;
            this.categoria = categoria;
        }
    }

}
