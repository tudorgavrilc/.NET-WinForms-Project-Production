using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW___Productie___Gavril_Tudor_1052C
{

    public partial class FormFiseConsum : Form
    {

        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BazaDeDate.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public FormFiseConsum()
        {
            InitializeComponent();
        }

    }
}
