using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoFilmesSCF.Model
{
    internal class ConexaoS
    {
        public static string ConectarS()
        {

            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lucas.dcamilo\source\repos\CatalogoFilmesSCF\CatalogoFilmesSCF\Model\filmesbd.mdf;Integrated Security=True";
        }
    }
}
