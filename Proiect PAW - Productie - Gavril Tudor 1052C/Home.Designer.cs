namespace Proiect_PAW___Productie___Gavril_Tudor_1052C
{
    partial class Home
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
            this.btnProduse = new System.Windows.Forms.Button();
            this.btnFiseConsum = new System.Windows.Forms.Button();
            this.btnLoturiFabricatie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProduse
            // 
            this.btnProduse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduse.Location = new System.Drawing.Point(43, 98);
            this.btnProduse.Name = "btnProduse";
            this.btnProduse.Size = new System.Drawing.Size(699, 55);
            this.btnProduse.TabIndex = 0;
            this.btnProduse.Text = "Produse";
            this.btnProduse.UseVisualStyleBackColor = true;
            this.btnProduse.Click += new System.EventHandler(this.btnProduse_Click);
            // 
            // btnFiseConsum
            // 
            this.btnFiseConsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiseConsum.Location = new System.Drawing.Point(43, 196);
            this.btnFiseConsum.Name = "btnFiseConsum";
            this.btnFiseConsum.Size = new System.Drawing.Size(699, 61);
            this.btnFiseConsum.TabIndex = 1;
            this.btnFiseConsum.Text = "Fise de consum";
            this.btnFiseConsum.UseVisualStyleBackColor = true;
            this.btnFiseConsum.Click += new System.EventHandler(this.btnFiseConsum_Click);
            // 
            // btnLoturiFabricatie
            // 
            this.btnLoturiFabricatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoturiFabricatie.Location = new System.Drawing.Point(43, 312);
            this.btnLoturiFabricatie.Name = "btnLoturiFabricatie";
            this.btnLoturiFabricatie.Size = new System.Drawing.Size(699, 63);
            this.btnLoturiFabricatie.TabIndex = 2;
            this.btnLoturiFabricatie.Text = "Loturi de fabricatie";
            this.btnLoturiFabricatie.UseVisualStyleBackColor = true;
            this.btnLoturiFabricatie.Click += new System.EventHandler(this.btnLoturiFabricatie_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoturiFabricatie);
            this.Controls.Add(this.btnFiseConsum);
            this.Controls.Add(this.btnProduse);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProduse;
        private System.Windows.Forms.Button btnFiseConsum;
        private System.Windows.Forms.Button btnLoturiFabricatie;
    }
}

