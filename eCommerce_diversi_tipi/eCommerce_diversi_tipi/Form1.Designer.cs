namespace eCommerce_diversi_tipi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxTipo = new ComboBox();
            textBoxMarca = new TextBox();
            textBoxCategoria = new TextBox();
            Add = new Button();
            listBoxCarrello = new ListBox();
            labelPrice = new Label();
            numericUpDownPrice = new NumericUpDown();
            textBoxScadenza = new TextBox();
            textBoxModello = new TextBox();
            labelSales = new Label();
            buttonRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Elettronico", "Alimentare" });
            comboBoxTipo.Location = new Point(207, 21);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(148, 23);
            comboBoxTipo.TabIndex = 0;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(12, 21);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(153, 23);
            textBoxMarca.TabIndex = 1;
            // 
            // textBoxCategoria
            // 
            textBoxCategoria.Location = new Point(12, 79);
            textBoxCategoria.Name = "textBoxCategoria";
            textBoxCategoria.Size = new Size(153, 23);
            textBoxCategoria.TabIndex = 2;
            // 
            // Add
            // 
            Add.Location = new Point(12, 191);
            Add.Name = "Add";
            Add.Size = new Size(348, 23);
            Add.TabIndex = 3;
            Add.Text = "Aggiungi";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // listBoxCarrello
            // 
            listBoxCarrello.FormattingEnabled = true;
            listBoxCarrello.ItemHeight = 15;
            listBoxCarrello.Location = new Point(435, 21);
            listBoxCarrello.Name = "listBoxCarrello";
            listBoxCarrello.Size = new Size(98, 229);
            listBoxCarrello.TabIndex = 4;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(446, 265);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(0, 15);
            labelPrice.TabIndex = 5;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(207, 79);
            numericUpDownPrice.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(148, 23);
            numericUpDownPrice.TabIndex = 6;
            numericUpDownPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBoxScadenza
            // 
            textBoxScadenza.Location = new Point(207, 134);
            textBoxScadenza.Name = "textBoxScadenza";
            textBoxScadenza.Size = new Size(153, 23);
            textBoxScadenza.TabIndex = 7;
            // 
            // textBoxModello
            // 
            textBoxModello.Location = new Point(12, 134);
            textBoxModello.Name = "textBoxModello";
            textBoxModello.Size = new Size(153, 23);
            textBoxModello.TabIndex = 8;
            // 
            // labelSales
            // 
            labelSales.AutoSize = true;
            labelSales.Location = new Point(496, 265);
            labelSales.Name = "labelSales";
            labelSales.Size = new Size(0, 15);
            labelSales.TabIndex = 9;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(435, 315);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(97, 23);
            buttonRemove.TabIndex = 10;
            buttonRemove.Text = "Rimuovi";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRemove);
            Controls.Add(labelSales);
            Controls.Add(textBoxModello);
            Controls.Add(textBoxScadenza);
            Controls.Add(numericUpDownPrice);
            Controls.Add(labelPrice);
            Controls.Add(listBoxCarrello);
            Controls.Add(Add);
            Controls.Add(textBoxCategoria);
            Controls.Add(textBoxMarca);
            Controls.Add(comboBoxTipo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTipo;
        private TextBox textBoxMarca;
        private TextBox textBoxCategoria;
        private Button Add;
        private ListBox listBoxCarrello;
        private Label labelPrice;
        private NumericUpDown numericUpDownPrice;
        private TextBox textBoxScadenza;
        private TextBox textBoxModello;
        private Label labelSales;
        private Button buttonRemove;
    }
}
