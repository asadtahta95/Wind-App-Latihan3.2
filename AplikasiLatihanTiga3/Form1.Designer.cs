﻿namespace AplikasiLatihanTiga3
{
    partial class frmLatihanTiga3
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
            this.lblNama = new System.Windows.Forms.Label();
            this.lblPendidikan = new System.Windows.Forms.Label();
            this.lblPekerjaan = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbPendidikan = new System.Windows.Forms.ComboBox();
            this.lstPekerjaan = new System.Windows.Forms.ListBox();
            this.txtPesan1 = new System.Windows.Forms.TextBox();
            this.txtPesan2 = new System.Windows.Forms.TextBox();
            this.txtPesan3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(50, 31);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(35, 13);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama";
            // 
            // lblPendidikan
            // 
            this.lblPendidikan.AutoSize = true;
            this.lblPendidikan.Location = new System.Drawing.Point(50, 57);
            this.lblPendidikan.Name = "lblPendidikan";
            this.lblPendidikan.Size = new System.Drawing.Size(60, 13);
            this.lblPendidikan.TabIndex = 0;
            this.lblPendidikan.Text = "Pendidikan";
            // 
            // lblPekerjaan
            // 
            this.lblPekerjaan.AutoSize = true;
            this.lblPekerjaan.Location = new System.Drawing.Point(50, 82);
            this.lblPekerjaan.Name = "lblPekerjaan";
            this.lblPekerjaan.Size = new System.Drawing.Size(55, 13);
            this.lblPekerjaan.TabIndex = 0;
            this.lblPekerjaan.Text = "Pekerjaan";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(218, 297);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(153, 28);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(100, 20);
            this.txtNama.TabIndex = 2;
            // 
            // cmbPendidikan
            // 
            this.cmbPendidikan.FormattingEnabled = true;
            this.cmbPendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "Diploma",
            "Sarjana",
            "Pascasarjana"});
            this.cmbPendidikan.Location = new System.Drawing.Point(153, 54);
            this.cmbPendidikan.Name = "cmbPendidikan";
            this.cmbPendidikan.Size = new System.Drawing.Size(121, 21);
            this.cmbPendidikan.TabIndex = 3;
            // 
            // lstPekerjaan
            // 
            this.lstPekerjaan.FormattingEnabled = true;
            this.lstPekerjaan.Items.AddRange(new object[] {
            "Pedagang",
            "PNS",
            "Dosen",
            "Swasta",
            "ABRI",
            "System Administrator"});
            this.lstPekerjaan.Location = new System.Drawing.Point(153, 81);
            this.lstPekerjaan.Name = "lstPekerjaan";
            this.lstPekerjaan.Size = new System.Drawing.Size(120, 95);
            this.lstPekerjaan.TabIndex = 4;
            this.lstPekerjaan.SelectedIndexChanged += new System.EventHandler(this.lstPekerjaan_SelectedIndexChanged);
            // 
            // txtPesan1
            // 
            this.txtPesan1.Enabled = false;
            this.txtPesan1.Location = new System.Drawing.Point(53, 185);
            this.txtPesan1.Name = "txtPesan1";
            this.txtPesan1.Size = new System.Drawing.Size(302, 20);
            this.txtPesan1.TabIndex = 2;
            // 
            // txtPesan2
            // 
            this.txtPesan2.Enabled = false;
            this.txtPesan2.Location = new System.Drawing.Point(53, 211);
            this.txtPesan2.Name = "txtPesan2";
            this.txtPesan2.Size = new System.Drawing.Size(302, 20);
            this.txtPesan2.TabIndex = 2;
            // 
            // txtPesan3
            // 
            this.txtPesan3.Enabled = false;
            this.txtPesan3.Location = new System.Drawing.Point(53, 237);
            this.txtPesan3.Name = "txtPesan3";
            this.txtPesan3.Size = new System.Drawing.Size(302, 20);
            this.txtPesan3.TabIndex = 2;
            // 
            // frmLatihanTiga3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPekerjaan);
            this.Controls.Add(this.cmbPendidikan);
            this.Controls.Add(this.txtPesan3);
            this.Controls.Add(this.txtPesan2);
            this.Controls.Add(this.txtPesan1);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPekerjaan);
            this.Controls.Add(this.lblPendidikan);
            this.Controls.Add(this.lblNama);
            this.Name = "frmLatihanTiga3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Latihan 3.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblPendidikan;
        private System.Windows.Forms.Label lblPekerjaan;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbPendidikan;
        private System.Windows.Forms.ListBox lstPekerjaan;
        private System.Windows.Forms.TextBox txtPesan1;
        private System.Windows.Forms.TextBox txtPesan2;
        private System.Windows.Forms.TextBox txtPesan3;
    }
}

