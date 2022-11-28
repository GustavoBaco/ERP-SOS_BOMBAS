using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace MySB.Formulários
{
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreencherUf()
        {
            cbxUf.Items.Add("Teste1");
            cbxUf.Items.Add("Teste2");
            cbxUf.Items.Add("Teste3");
            cbxUf.Items.Add("Teste4");
        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {
            PreencherUf();
        }
    }
}
