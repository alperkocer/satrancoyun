namespace Satranc
{
    partial class Form1
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
            this.pnlTahta = new System.Windows.Forms.Panel();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.cmbTas = new System.Windows.Forms.ComboBox();
            this.btnHareket = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTahta
            // 
            this.pnlTahta.BackColor = System.Drawing.Color.White;
            this.pnlTahta.Location = new System.Drawing.Point(0, 0);
            this.pnlTahta.Name = "pnlTahta";
            this.pnlTahta.Size = new System.Drawing.Size(400, 400);
            this.pnlTahta.TabIndex = 0;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(454, 66);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(142, 23);
            this.btnOlustur.TabIndex = 1;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // cmbTas
            // 
            this.cmbTas.FormattingEnabled = true;
            this.cmbTas.Items.AddRange(new object[] {
            "Kale",
            "Fil",
            "At"});
            this.cmbTas.Location = new System.Drawing.Point(433, 27);
            this.cmbTas.Name = "cmbTas";
            this.cmbTas.Size = new System.Drawing.Size(177, 21);
            this.cmbTas.TabIndex = 2;
            this.cmbTas.SelectedIndexChanged += new System.EventHandler(this.cmbTas_SelectedIndexChanged);
            // 
            // btnHareket
            // 
            this.btnHareket.Location = new System.Drawing.Point(454, 118);
            this.btnHareket.Name = "btnHareket";
            this.btnHareket.Size = new System.Drawing.Size(142, 21);
            this.btnHareket.TabIndex = 3;
            this.btnHareket.Text = "Hareket Ettir";
            this.btnHareket.UseVisualStyleBackColor = true;
            this.btnHareket.Click += new System.EventHandler(this.btnHareket_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Satranc.Properties.Resources.atfilkale;
            this.pictureBox1.Location = new System.Drawing.Point(433, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 183);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHareket);
            this.Controls.Add(this.cmbTas);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.pnlTahta);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnHareket;
        public System.Windows.Forms.Panel pnlTahta;
        public System.Windows.Forms.ComboBox cmbTas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

