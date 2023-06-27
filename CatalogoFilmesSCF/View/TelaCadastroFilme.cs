using CatalogoFilmesSCF.Controller;
using CatalogoFilmesSCF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoFilmesSCF.View
{
    public partial class TelaCadastroFilme : Form
    {
        public TelaCadastroFilme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filme.NomeFilme = txbox_filme.Text;
            Filme.EstreiaFilme = txb_estreia.Text;
            Filme.DuracaoFilme = txt_duracao.Text;
            Filme.CategoriaFilme = cmb_Categoria.Text;

            FilmeController filmecontroller = new FilmeController();
            filmecontroller.CadastrarFilme();

            if(Filme.RetornoFilme == "f")
            {
                this.Close();
            }
        }
        public void FecharTela()
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
