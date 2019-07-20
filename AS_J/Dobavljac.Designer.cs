namespace AS_J
{
    partial class Dobavljac
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.linkLabelStampa = new System.Windows.Forms.LinkLabel();
            this.linkLabelPretraga = new System.Windows.Forms.LinkLabel();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxPLTelefon1 = new System.Windows.Forms.TextBox();
            this.textBoxPLAdresa = new System.Windows.Forms.TextBox();
            this.textBoxPLMesto = new System.Windows.Forms.TextBox();
            this.textBoxPIB = new System.Windows.Forms.TextBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.dataGridViewPravnaLica = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPravnaLica)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1191, 611);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.textBoxEmail);
            this.tabPage1.Controls.Add(this.linkLabelStampa);
            this.tabPage1.Controls.Add(this.linkLabelPretraga);
            this.tabPage1.Controls.Add(this.buttonIzmeni);
            this.tabPage1.Controls.Add(this.buttonObrisi);
            this.tabPage1.Controls.Add(this.buttonSacuvaj);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.textBoxPLTelefon1);
            this.tabPage1.Controls.Add(this.textBoxPLAdresa);
            this.tabPage1.Controls.Add(this.textBoxPLMesto);
            this.tabPage1.Controls.Add(this.textBoxPIB);
            this.tabPage1.Controls.Add(this.textBoxNaziv);
            this.tabPage1.Controls.Add(this.textBoxSifra);
            this.tabPage1.Controls.Add(this.dataGridViewPravnaLica);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1183, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dobavljači";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(563, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 17);
            this.label17.TabIndex = 44;
            this.label17.Text = "email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(614, 89);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(241, 22);
            this.textBoxEmail.TabIndex = 6;
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabelStampa
            // 
            this.linkLabelStampa.AutoSize = true;
            this.linkLabelStampa.Location = new System.Drawing.Point(1099, 126);
            this.linkLabelStampa.Name = "linkLabelStampa";
            this.linkLabelStampa.Size = new System.Drawing.Size(59, 17);
            this.linkLabelStampa.TabIndex = 8;
            this.linkLabelStampa.TabStop = true;
            this.linkLabelStampa.Text = "Štampaj";
            // 
            // linkLabelPretraga
            // 
            this.linkLabelPretraga.AutoSize = true;
            this.linkLabelPretraga.Location = new System.Drawing.Point(140, 126);
            this.linkLabelPretraga.Name = "linkLabelPretraga";
            this.linkLabelPretraga.Size = new System.Drawing.Size(63, 17);
            this.linkLabelPretraga.TabIndex = 7;
            this.linkLabelPretraga.TabStop = true;
            this.linkLabelPretraga.Text = "Pretraga";
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(393, 532);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(77, 44);
            this.buttonIzmeni.TabIndex = 10;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(574, 532);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(76, 44);
            this.buttonObrisi.TabIndex = 11;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Location = new System.Drawing.Point(228, 532);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(79, 44);
            this.buttonSacuvaj.TabIndex = 9;
            this.buttonSacuvaj.Text = "Sačuvaj";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(548, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Telefon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(300, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Adresa:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(300, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Mesto:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "PIB:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "Naziv:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 17);
            this.label16.TabIndex = 29;
            this.label16.Text = "Šifra:";
            // 
            // textBoxPLTelefon1
            // 
            this.textBoxPLTelefon1.Location = new System.Drawing.Point(614, 55);
            this.textBoxPLTelefon1.Name = "textBoxPLTelefon1";
            this.textBoxPLTelefon1.Size = new System.Drawing.Size(241, 22);
            this.textBoxPLTelefon1.TabIndex = 5;
            this.textBoxPLTelefon1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPLAdresa
            // 
            this.textBoxPLAdresa.Location = new System.Drawing.Point(364, 93);
            this.textBoxPLAdresa.Name = "textBoxPLAdresa";
            this.textBoxPLAdresa.Size = new System.Drawing.Size(175, 22);
            this.textBoxPLAdresa.TabIndex = 4;
            this.textBoxPLAdresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPLMesto
            // 
            this.textBoxPLMesto.Location = new System.Drawing.Point(364, 53);
            this.textBoxPLMesto.Name = "textBoxPLMesto";
            this.textBoxPLMesto.Size = new System.Drawing.Size(175, 22);
            this.textBoxPLMesto.TabIndex = 3;
            this.textBoxPLMesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPIB
            // 
            this.textBoxPIB.Location = new System.Drawing.Point(97, 94);
            this.textBoxPIB.Name = "textBoxPIB";
            this.textBoxPIB.Size = new System.Drawing.Size(197, 22);
            this.textBoxPIB.TabIndex = 2;
            this.textBoxPIB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNaziv.Location = new System.Drawing.Point(97, 54);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(197, 22);
            this.textBoxNaziv.TabIndex = 1;
            this.textBoxNaziv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSifra.Location = new System.Drawing.Point(97, 15);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.Size = new System.Drawing.Size(158, 22);
            this.textBoxSifra.TabIndex = 0;
            this.textBoxSifra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewPravnaLica
            // 
            this.dataGridViewPravnaLica.AllowUserToAddRows = false;
            this.dataGridViewPravnaLica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPravnaLica.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPravnaLica.Location = new System.Drawing.Point(6, 154);
            this.dataGridViewPravnaLica.Name = "dataGridViewPravnaLica";
            this.dataGridViewPravnaLica.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPravnaLica.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPravnaLica.RowTemplate.Height = 24;
            this.dataGridViewPravnaLica.Size = new System.Drawing.Size(1171, 372);
            this.dataGridViewPravnaLica.TabIndex = 12;
            // 
            // Dobavljac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 620);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dobavljac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dobavljac";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPravnaLica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.LinkLabel linkLabelStampa;
        private System.Windows.Forms.LinkLabel linkLabelPretraga;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxPLTelefon1;
        private System.Windows.Forms.TextBox textBoxPLAdresa;
        private System.Windows.Forms.TextBox textBoxPLMesto;
        private System.Windows.Forms.TextBox textBoxPIB;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.DataGridView dataGridViewPravnaLica;
    }
}