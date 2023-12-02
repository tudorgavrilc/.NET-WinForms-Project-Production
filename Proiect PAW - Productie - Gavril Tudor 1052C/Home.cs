using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect_PAW___Productie___Gavril_Tudor_1052C
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnProduse_Click(object sender, EventArgs e)
        {
           FormProduse produseForm = new FormProduse();
            produseForm.Show();
        }

        private void btnFiseConsum_Click(object sender, EventArgs e)
        {
            FormFiseConsum fiseConsumForm = new FormFiseConsum();
            fiseConsumForm.Show();
        }

        private void btnLoturiFabricatie_Click(object sender, EventArgs e)
        {
            FormLoturiFabricatie loturiFabricatieForm = new FormLoturiFabricatie();
            loturiFabricatieForm.Show();
        }
    }
}
