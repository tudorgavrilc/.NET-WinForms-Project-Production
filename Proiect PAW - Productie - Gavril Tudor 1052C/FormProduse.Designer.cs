namespace Proiect_PAW___Productie___Gavril_Tudor_1052C
{
    partial class FormProduse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduse));
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSterge = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModifica = new System.Windows.Forms.Button();
            this.tbDenumireModificata = new System.Windows.Forms.TextBox();
            this.tbPretModificat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvareFisierTxt = new System.Windows.Forms.Button();
            this.btnRestaurareFisierTxt = new System.Windows.Forms.Button();
            this.btnSalvareXml = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(146, 36);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 0;
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(146, 131);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(100, 20);
            this.tbPret.TabIndex = 1;
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(146, 80);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(100, 20);
            this.tbDenumire.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Denumire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pret";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(35, 184);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(211, 23);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "Adauga in baza de date";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 186);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(35, 213);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(211, 23);
            this.btnSterge.TabIndex = 8;
            this.btnSterge.Text = "Sterge produsul selectat";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModifica);
            this.panel1.Controls.Add(this.tbDenumireModificata);
            this.panel1.Controls.Add(this.tbPretModificat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(303, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 171);
            this.panel1.TabIndex = 9;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(26, 133);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(197, 23);
            this.btnModifica.TabIndex = 10;
            this.btnModifica.Text = "Modifica produsul selectat";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // tbDenumireModificata
            // 
            this.tbDenumireModificata.Location = new System.Drawing.Point(123, 44);
            this.tbDenumireModificata.Name = "tbDenumireModificata";
            this.tbDenumireModificata.Size = new System.Drawing.Size(100, 20);
            this.tbDenumireModificata.TabIndex = 9;
            // 
            // tbPretModificat
            // 
            this.tbPretModificat.Location = new System.Drawing.Point(123, 91);
            this.tbPretModificat.Name = "tbPretModificat";
            this.tbPretModificat.Size = new System.Drawing.Size(100, 20);
            this.tbPretModificat.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pret modificat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Denumire modificata";
            // 
            // btnSalvareFisierTxt
            // 
            this.btnSalvareFisierTxt.Location = new System.Drawing.Point(607, 36);
            this.btnSalvareFisierTxt.Name = "btnSalvareFisierTxt";
            this.btnSalvareFisierTxt.Size = new System.Drawing.Size(181, 23);
            this.btnSalvareFisierTxt.TabIndex = 10;
            this.btnSalvareFisierTxt.Text = "Salveaza in fisier .txt";
            this.btnSalvareFisierTxt.UseVisualStyleBackColor = true;
            this.btnSalvareFisierTxt.Click += new System.EventHandler(this.btnSalvareFisierTxt_Click);
            // 
            // btnRestaurareFisierTxt
            // 
            this.btnRestaurareFisierTxt.Location = new System.Drawing.Point(607, 87);
            this.btnRestaurareFisierTxt.Name = "btnRestaurareFisierTxt";
            this.btnRestaurareFisierTxt.Size = new System.Drawing.Size(181, 23);
            this.btnRestaurareFisierTxt.TabIndex = 11;
            this.btnRestaurareFisierTxt.Text = "Adauga valori din fisier .txt";
            this.btnRestaurareFisierTxt.UseVisualStyleBackColor = true;
            this.btnRestaurareFisierTxt.Click += new System.EventHandler(this.btnRestaurareFisierTxt_Click);
            // 
            // btnSalvareXml
            // 
            this.btnSalvareXml.Location = new System.Drawing.Point(607, 138);
            this.btnSalvareXml.Name = "btnSalvareXml";
            this.btnSalvareXml.Size = new System.Drawing.Size(181, 23);
            this.btnSalvareXml.TabIndex = 12;
            this.btnSalvareXml.Text = "Salveaza in fisier .xml";
            this.btnSalvareXml.UseVisualStyleBackColor = true;
            this.btnSalvareXml.Click += new System.EventHandler(this.btnSalvareXml_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(607, 184);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(181, 23);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Printeaza";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSalvareXml);
            this.Controls.Add(this.btnRestaurareFisierTxt);
            this.Controls.Add(this.btnSalvareFisierTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbID);
            this.Name = "FormProduse";
            this.Text = "Produse";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.TextBox tbDenumireModificata;
        private System.Windows.Forms.TextBox tbPretModificat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvareFisierTxt;
        private System.Windows.Forms.Button btnRestaurareFisierTxt;
        private System.Windows.Forms.Button btnSalvareXml;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}