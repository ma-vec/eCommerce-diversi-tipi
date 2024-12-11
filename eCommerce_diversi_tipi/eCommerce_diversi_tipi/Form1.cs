using eCommerce;

namespace eCommerce_diversi_tipi
{
    public partial class Form1 : Form
    {
        private int numCrescente = 1; //per generare automaticamente id
        private double totPrezzo = 0;
        private double PrezzoScontato = 0;
        private string fileExtension = ".json";
        private double scontoAlimentari = 20;
        private double scontoElettronica = 10;
        Carrello C = new Carrello("1");

        public Form1()
        {
            InitializeComponent();
        }

        private void AggiornaInterfaccia()
        {
            listBoxCarrello.DataSource = null;
            listBoxCarrello.DataSource = C.ProdottiCarrello;
            listBoxCarrello.DisplayMember = "modelloId";
            labelPrice.Text = totPrezzo.ToString();
            labelSales.Text = PrezzoScontato.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            //scelta tipologia prodotto. 0 elettronico
            switch (comboBoxTipo.SelectedIndex)
            {
                case 0:
                    ProdottoElettronico prodottoEl = new ProdottoElettronico(textBoxScadenza.Text, textBoxCategoria.Text, textBoxMarca.Text, textBoxModello.Text, "E" + numCrescente, Convert.ToInt32(numericUpDownPrice.Value));
                    C.aggiungiProdotto(prodottoEl);
                    numCrescente++;
                    prodottoEl.OttieniModelloId(); //per uniformare listbox
                    totPrezzo += prodottoEl.Prezzo;
                    prodottoEl.ApplicaSconto(scontoElettronica);
                    PrezzoScontato += prodottoEl.Prezzo;

                    break;
                case 1:
                    ProdottoAlimentare prodottoAl = new ProdottoAlimentare(textBoxScadenza.Text, textBoxCategoria.Text, textBoxMarca.Text, textBoxModello.Text, "A" + numCrescente, Convert.ToInt32(numericUpDownPrice.Value));
                    C.aggiungiProdotto(prodottoAl);
                    numCrescente++;
                    prodottoAl.OttieniModelloId(); //per uniformare listbox
                    totPrezzo += prodottoAl.Prezzo;
                    prodottoAl.ApplicaSconto(scontoAlimentari);
                    PrezzoScontato += prodottoAl.Prezzo;

                    break;
                default:
                    MessageBox.Show("Compila i dati richiesti");
                    break;
            }
            AggiornaInterfaccia();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxCarrello.SelectedIndex;

            // Verifica che un elemento sia selezionato
            if (selectedIndex != -1)
            {
                Prodotto prodottoSelezionato = C.ProdottiCarrello[selectedIndex];

                C.rimuoviProdotto(prodottoSelezionato);
                totPrezzo -= prodottoSelezionato.Prezzo;
                AggiornaInterfaccia();
            }
            else
            {
                MessageBox.Show("Seleziona un prodotto da rimuovere cliccandolo dal carrello.");
            }
        }
    }
}
