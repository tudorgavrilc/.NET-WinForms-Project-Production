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
using System.Xml.Serialization;

namespace Proiect_PAW___Productie___Gavril_Tudor_1052C
{
    public partial class FormLoturiFabricatie : Form
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COD\FACULTATE\c#\Proiect PAW - Productie - Gavril Tudor 1052C\Proiect PAW - Productie - Gavril Tudor 1052C\BazaDeDate.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlCommand cmd2;
        DataTable dataTable = new DataTable();
        SqlDataAdapter adapter;
        string filePath = "D:\\COD\\FACULTATE\\c#\\Proiect PAW - Productie - Gavril Tudor 1052C\\fisierLoturiFabricatie.txt";
        public FormLoturiFabricatie()
        {
            InitializeComponent();
            connection.Open();
            cmd2 = new SqlCommand("SELECT IdLotFabricatie, NrTipuriProduse, IdProduse, NrExemplareProduse, NrProduseTotale" +
                "  FROM LoturiFabricatie", connection);
            cmd2.ExecuteNonQuery();
            adapter = new SqlDataAdapter(cmd2);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void btnCalculeazaNrProduseTotal_Click(object sender, EventArgs e)
        {
            string[] stringNrExemplareProduse = tbNrExemplareProduse.Text.Split(',');
            int[] arrayNrExemplareProduse = Array.ConvertAll(stringNrExemplareProduse, int.Parse);
            LotFabricatie lot = new LotFabricatie(1, Convert.ToInt32(tbNrTipuriProduse.Text), arrayNrExemplareProduse, arrayNrExemplareProduse);
            tbNrProduseTotale.Text = Convert.ToString(lot.calculeazaNrProduseTotale());
        }

        private void btnAdaugaLot_Click(object sender, EventArgs e)
        {
            connection.Open();
            LotFabricatie lot = new LotFabricatie();
            lot.IdLotFabricatie = Convert.ToInt32(tbIdLotFabricatie.Text);
            lot.NrTipuriProduse = Convert.ToInt32(tbNrTipuriProduse.Text);

            //string[] stringIdProduse = tbIDProduse.Text.Split(',');
            //int[] arrayIdProduse = Array.ConvertAll(stringIdProduse, int.Parse);
            //lot.IdProduse = arrayIdProduse;

            //string[] stringNrExemplareProduse = tbNrExemplareProduse.Text.Split(',');
            //int[] arrayNrExemplareProduse = Array.ConvertAll(stringNrExemplareProduse, int.Parse);
            //lot.NrExemplareProduse = arrayNrExemplareProduse;

            lot.NrProduseTotale = Convert.ToInt32(tbNrProduseTotale.Text);

            cmd = new SqlCommand("INSERT INTO LoturiFabricatie(IdLotFabricatie, NrTipuriProduse, IdProduse, " +
                "NrExemplareProduse, NrProduseTotale) VALUES(@idlot,@nrtipuriproduse,@idproduse,@nrexemplare,@nrprodusetotale)",connection);

            cmd.Parameters.AddWithValue("@idlot", lot.IdLotFabricatie);
            cmd.Parameters.AddWithValue("@nrtipuriproduse", lot.NrTipuriProduse);
            cmd.Parameters.AddWithValue("@idproduse", tbIDProduse.Text);
            cmd.Parameters.AddWithValue("@nrexemplare", tbNrExemplareProduse.Text);
            cmd.Parameters.AddWithValue("@nrprodusetotale", lot.NrProduseTotale);
            cmd.ExecuteNonQuery();

            cmd2 = new SqlCommand("SELECT IdLotFabricatie, NrTipuriProduse, IdProduse, NrExemplareProduse, NrProduseTotale FROM LoturiFabricatie", connection);
            cmd2.ExecuteNonQuery();
            adapter = new SqlDataAdapter(cmd2);
            dataTable.Clear();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();

            MessageBox.Show("Lot Fabricatie adaugat cu succes!");
        }

        private void btnStergeLot_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int idToDelete = Convert.ToInt32(selectedRow.Cells["IdLotFabricatie"].Value);

            connection.Open();
            cmd = new SqlCommand("DELETE FROM LoturiFabricatie WHERE IdLotFabricatie = @id", connection);
            cmd.Parameters.AddWithValue("id", idToDelete);
            cmd.ExecuteNonQuery();

            cmd2 = new SqlCommand("SELECT IdLotFabricatie, NrTipuriProduse, IdProduse, NrExemplareProduse, NrProduseTotale FROM LoturiFabricatie", connection);
            cmd2.ExecuteNonQuery();
            adapter = new SqlDataAdapter(cmd2);
            dataTable.Clear();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();

            MessageBox.Show("Lotul cu ID-ul " + idToDelete + " a fost sters cu succes!");
        }

        private void btnModificaLot_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int idToUpdate = Convert.ToInt32(selectedRow.Cells["IdLotFabricatie"].Value);
            LotFabricatie lot = new LotFabricatie();

            connection.Open();
            lot.IdLotFabricatie = Convert.ToInt32(tbIdLotFabricatieModificat.Text);
            lot.NrTipuriProduse = Convert.ToInt32(tbNrTipuriProduseModificate.Text);
            lot.NrProduseTotale = Convert.ToInt32(tbNrProduseTotaleModificate.Text);
            cmd = new SqlCommand("UPDATE LoturiFabricatie SET  NrTipuriProduse=@nrtipuriproduse, IdProduse=@idproduse, NrExemplareProduse=@nrexemplare, NrproduseTotale=@nrprodusetotale WHERE IdLotFabricatie = @id", connection);
            cmd.Parameters.AddWithValue("@id", idToUpdate);
            cmd.Parameters.AddWithValue("@nrtipuriproduse", lot.NrTipuriProduse);
            cmd.Parameters.AddWithValue("@idproduse", tbIDProduseModificate.Text);
            cmd.Parameters.AddWithValue("@nrexemplare", tbNrExemplareProduseModificate.Text);
            cmd.Parameters.AddWithValue("@nrprodusetotale", lot.NrProduseTotale);
            cmd.ExecuteNonQuery();

            cmd2 = new SqlCommand("SELECT IdLotFabricatie, NrTipuriProduse, IdProduse, NrExemplareProduse, NrProduseTotale FROM LoturiFabricatie", connection);
            cmd2.ExecuteNonQuery();
            adapter = new SqlDataAdapter(cmd2);
            dataTable.Clear();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();

            MessageBox.Show("Elementul cu ID-ul " + idToUpdate + " a fost modificat cu succes!");
        }

        private void btnSalveazaFisierTxt_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        sb.Append(cell.Value);
                        sb.Append(";");
                    }

                    sb.AppendLine();
                }
            }

            File.WriteAllText(filePath, sb.ToString());

            MessageBox.Show("Salvarea in fisierul text a fost realizata cu succes!");
        }

        private void btnAdaugaDinTxt_Click(object sender, EventArgs e)
        {
            connection.Open();
            cmd = new SqlCommand("INSERT INTO LoturiFabricatie(IdLotFabricatie, NrTipuriProduse, IdProduse, " +
                "NrExemplareProduse, NrProduseTotale) VALUES(@idlot,@nrtipuriproduse,@idproduse,@nrexemplare,@nrprodusetotale)", connection);

            StreamReader streamReader = new StreamReader(filePath);
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                cmd.Parameters.Clear();

                string[] values = line.Split(';');
                cmd.Parameters.AddWithValue("@idlot", values[0]);
                cmd.Parameters.AddWithValue("@nrtipuriproduse", values[1]);
                cmd.Parameters.AddWithValue("@idproduse", values[2]);
                cmd.Parameters.AddWithValue("@nrexemplare", values[3]);
                cmd.Parameters.AddWithValue("@nrprodusetotale", values[4]);

                cmd.ExecuteNonQuery();
            }

            cmd2 = new SqlCommand("SELECT IdLotFabricatie, NrTipuriProduse, IdProduse, NrExemplareProduse, " +
                "NrProduseTotale FROM LoturiFabricatie", connection);
            cmd2.ExecuteNonQuery();
            adapter = new SqlDataAdapter(cmd2);
            dataTable.Clear();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void btnSalveazaInXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            saveFileDialog.Title = "Salveaza fisier XML";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                dataTable.TableName = "LoturiFabricatie";

                StreamWriter streamWriter = new StreamWriter(fileName);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataTable));
                xmlSerializer.Serialize(streamWriter, dataTable);

                MessageBox.Show("Datele au fost salvate cu succes in fisierul XML!");
            }
        }

        

        Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
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

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}


