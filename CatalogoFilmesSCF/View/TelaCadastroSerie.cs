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
    public partial class TelaCadastroSerie : Form
    {
        public TelaCadastroSerie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Serie.NomeSerie = txbox_serie.Text;
            Serie.EstreiaSerie = txb_estreia.Text;
            Serie.TemporadasSerie = txt_Temporadas.Text;
            Serie.CategoriaSerie = cmb_Categoria.Text;

            SerieController seriecontroller = new SerieController();
            seriecontroller.CadastrarSerie();
        }
    }
}
