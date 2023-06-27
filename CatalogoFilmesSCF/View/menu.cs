using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoFilmesSCF.View
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCadastroFilme tela = new TelaCadastroFilme();
     
            tela.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TelaCadastroSerie tela = new TelaCadastroSerie();

            tela.Show();
        }
    }
}
