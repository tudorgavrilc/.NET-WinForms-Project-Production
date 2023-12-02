using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;

namespace Proiect_PAW___Productie___Gavril_Tudor_1052C
{
    public partial class FormProduse : Form
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COD\FACULTATE\c#\Proiect PAW - Productie - Gavril Tudor 1052C\Proiect PAW - Productie - Gavril Tudor 1052C\BazaDeDate.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlCommand cmd2;
        DataTable dataTable = new DataTable();
        SqlDataAdapter adapter;
        string filePath = "D:\\COD\\FACULTATE\\c#\\Proiect PAW - Productie - Gavril Tudor 1052C\\fisier.txt";
        public FormProduse()
        {
            InitializeComponent();
            connection.Open();
            cmd2 = new SqlCommand("SELECT Id, Denumire, Pret FROM Produse", connection);
            cmd2.ExecuteNonQuery();
            adapter = new SqlDataAdapter(cmd2);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            connection.Open();
            Produs produs = new Produs();
            produs.Id = Int32.Parse(tbID.Text);
            produs.Denumire = tbDenumire.Text;
            produs.Pret = float.Parse(tbPret.Text);

            cmd = new SqlCommand("INSERT INTO Produse(Id, Denumire, Pret) VALUES(@id, @denumire, @pret)", connection);
            cmd.Parameters.AddWithValue("@id", produs.Id);
            cmd.Parameters.AddWithValue("@denumire", produs.Denumire);
            cmd.Parameters.AddWithValue("@pret", produs.Pret);
            cmd.ExecuteNonQuery();

            cmd2 = new SqlCommand("SELECT Id, Denumire, Pret FROM Produse", connection);
            cmd2.ExecuteNonQuery();
            adapter = new SqlDataAdapter(cmd2);
            dataTable.Clear();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();

            MessageBox.Show("Produs adaugat cu succes!");

            tbID.Text = string.Empty;
            tbDenumire.Text = string.Empty;
            tbPret.Text = string.Empty;


        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int idToDelete = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            connection.Open();
            cmd = new SqlCommand("DELETE FROM Produse WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", idToDelete);
            cmd.ExecuteNonQuery();

            cmd2 = new SqlCommand("SELECT Id, Denumire, Pret FROM Produse", connection);
            cmd2.ExecuteNonQuery();
            adapter = new SqlDataAdapter(cmd2);
            dataTable.Clear();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
  
            connection.Close();

            MessageBox.Show("Elementul cu ID-ul " + idToDelete + " a fost sters cu succes!"); 
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            int idToUpdate = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            string newDenumire = tbDenumireModificata.Text;
            float newPret = float.Parse(tbPretModificat.Text);

            connection.Open();
            cmd = new SqlCommand("UPDATE Produse SET Pret = @pret, Denumire = @denumire WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@denumire", newDenumire);
            cmd.Parameters.AddWithValue("@pret", newPret);
            cmd.Parameters.AddWithValue("@id", idToUpdate);

            cmd.ExecuteNonQuery();

            cmd2 = new SqlCommand("SELECT Id, Denumire, Pret FROM Produse", connection);
            cmd2.ExecuteNonQuery();
            adapter = new SqlDataAdapter(cmd2);
            dataTable.Clear();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            connection.Close();

            MessageBox.Show("Elementul cu ID-ul " + idToUpdate + " a fost modificat cu succes!");
        }

        private void btnSalvareFisierTxt_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        sb.Append(cell.Value);
                        sb.Append(","); 
                    }

                    sb.AppendLine(); 
                }
            }

            File.WriteAllText(filePath, sb.ToString());

            MessageBox.Show("Salvarea in fisierul text a fost realizata cu succes!");
        }

        private void btnRestaurareFisierTxt_Click(object sender, EventArgs e)
        {
            connection.Open();
            cmd = new SqlCommand("INSERT INTO Produse (ID, Denumire, Pret) VALUES (@id, @denumire, @pret)", connection);
            
            StreamReader streamReader = new StreamReader(filePath);
            string line;
            while((line = streamReader.ReadLine()) != null)
            {
                string[] values = line.Split(',');
                cmd.Parameters.AddWithValue("@id", values[0]);
                cmd.Parameters.AddWithValue("@denumire", values[1]);
                cmd.Parameters.AddWithValue("@pret", values[2]);

                cmd.ExecuteNonQuery();
            }

            cmd2 = new SqlCommand("SELECT Id, Denumire, Pret FROM Produse", connection);
            cmd2.ExecuteNonQuery();
            adapter = new SqlDataAdapter(cmd2);
            dataTable.Clear();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        Bitmap bitmap;
        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void btnSalvareXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            saveFileDialog.Title = "Salveaza fisier XML";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                dataTable.TableName = "Produse";

                StreamWriter streamWriter = new StreamWriter(fileName);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataTable));
                xmlSerializer.Serialize(streamWriter, dataTable);

                MessageBox.Show("Datele au fost salvate cu succes in fisierul XML!");
            }
        }

    }
}
