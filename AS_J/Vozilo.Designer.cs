namespace AS_J
{
    partial class Vozilo
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
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.textBoxTIP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxVlasnik = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKubikaza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGorivo = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBRSasije = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxBRMotora = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.textBoxRGBR = new System.Windows.Forms.TextBox();
            this.dataGridViewVozila = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPodaciOVlasniku = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxBoja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(5, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1191, 611);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxMarka);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.textBoxBoja);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxPodaciOVlasniku);
            this.tabPage1.Controls.Add(this.linkLabel3);
            this.tabPage1.Controls.Add(this.textBoxTIP);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBoxVlasnik);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxKubikaza);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxGorivo);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.linkLabel2);
            this.tabPage1.Controls.Add(this.buttonIzmeni);
            this.tabPage1.Controls.Add(this.buttonObrisi);
            this.tabPage1.Controls.Add(this.buttonSacuvaj);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBoxBRSasije);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.textBoxBRMotora);
            this.tabPage1.Controls.Add(this.textBoxModel);
            this.tabPage1.Controls.Add(this.textBoxGodinaProizvodnje);
            this.tabPage1.Controls.Add(this.textBoxRGBR);
            this.tabPage1.Controls.Add(this.dataGridViewVozila);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1183, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vozilo";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(616, 16);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(143, 17);
            this.linkLabel3.TabIndex = 52;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Dodaj novog vlasnika";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // textBoxTIP
            // 
            this.textBoxTIP.Location = new System.Drawing.Point(128, 19);
            this.textBoxTIP.Name = "textBoxTIP";
            this.textBoxTIP.Size = new System.Drawing.Size(159, 22);
            this.textBoxTIP.TabIndex = 1;
            this.textBoxTIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(938, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Čitač saobraćajne dozvole";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxVlasnik
            // 
            this.comboBoxVlasnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVlasnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVlasnik.FormattingEnabled = true;
            this.comboBoxVlasnik.Location = new System.Drawing.Point(372, 10);
            this.comboBoxVlasnik.Name = "comboBoxVlasnik";
            this.comboBoxVlasnik.Size = new System.Drawing.Size(238, 28);
            this.comboBoxVlasnik.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Vlasnik:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1008, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Kubikaza";
            // 
            // textBoxKubikaza
            // 
            this.textBoxKubikaza.Location = new System.Drawing.Point(1080, 87);
            this.textBoxKubikaza.Name = "textBoxKubikaza";
            this.textBoxKubikaza.Size = new System.Drawing.Size(94, 22);
            this.textBoxKubikaza.TabIndex = 9;
            this.textBoxKubikaza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(924, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Gorivo:";
            // 
            // textBoxGorivo
            // 
            this.textBoxGorivo.Location = new System.Drawing.Point(984, 51);
            this.textBoxGorivo.Name = "textBoxGorivo";
            this.textBoxGorivo.Size = new System.Drawing.Size(190, 22);
            this.textBoxGorivo.TabIndex = 8;
            this.textBoxGorivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1098, 167);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Štampaj";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(139, 167);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(63, 17);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Pretraga";
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(393, 532);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(77, 44);
            this.buttonIzmeni.TabIndex = 14;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(574, 532);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(76, 44);
            this.buttonObrisi.TabIndex = 15;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Location = new System.Drawing.Point(228, 532);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(79, 44);
            this.buttonSacuvaj.TabIndex = 13;
            this.buttonSacuvaj.Text = "Sačuvaj";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            this.buttonSacuvaj.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(673, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Broj šasije:";
            // 
            // textBoxBRSasije
            // 
            this.textBoxBRSasije.Location = new System.Drawing.Point(756, 87);
            this.textBoxBRSasije.Name = "textBoxBRSasije";
            this.textBoxBRSasije.Size = new System.Drawing.Size(222, 22);
            this.textBoxBRSasije.TabIndex = 7;
            this.textBoxBRSasije.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(605, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Broj motora:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(369, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Model:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Godina:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "Registarski broj:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 17);
            this.label16.TabIndex = 29;
            this.label16.Text = "TIP:";
            // 
            // textBoxBRMotora
            // 
            this.textBoxBRMotora.Location = new System.Drawing.Point(696, 51);
            this.textBoxBRMotora.Name = "textBoxBRMotora";
            this.textBoxBRMotora.Size = new System.Drawing.Size(222, 22);
            this.textBoxBRMotora.TabIndex = 6;
            this.textBoxBRMotora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(425, 92);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(242, 22);
            this.textBoxModel.TabIndex = 5;
            this.textBoxModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGodinaProizvodnje
            // 
            this.textBoxGodinaProizvodnje.Location = new System.Drawing.Point(425, 52);
            this.textBoxGodinaProizvodnje.Name = "textBoxGodinaProizvodnje";
            this.textBoxGodinaProizvodnje.Size = new System.Drawing.Size(174, 22);
            this.textBoxGodinaProizvodnje.TabIndex = 4;
            this.textBoxGodinaProizvodnje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRGBR
            // 
            this.textBoxRGBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRGBR.Location = new System.Drawing.Point(129, 56);
            this.textBoxRGBR.Name = "textBoxRGBR";
            this.textBoxRGBR.Size = new System.Drawing.Size(226, 28);
            this.textBoxRGBR.TabIndex = 2;
            this.textBoxRGBR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewVozila
            // 
            this.dataGridViewVozila.AllowUserToAddRows = false;
            this.dataGridViewVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVozila.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVozila.Location = new System.Drawing.Point(6, 197);
            this.dataGridViewVozila.Name = "dataGridViewVozila";
            this.dataGridViewVozila.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVozila.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVozila.RowTemplate.Height = 24;
            this.dataGridViewVozila.Size = new System.Drawing.Size(1171, 329);
            this.dataGridViewVozila.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Podaci o vlasniku:";
            // 
            // textBoxPodaciOVlasniku
            // 
            this.textBoxPodaciOVlasniku.Location = new System.Drawing.Point(160, 134);
            this.textBoxPodaciOVlasniku.Name = "textBoxPodaciOVlasniku";
            this.textBoxPodaciOVlasniku.ReadOnly = true;
            this.textBoxPodaciOVlasniku.Size = new System.Drawing.Size(608, 22);
            this.textBoxPodaciOVlasniku.TabIndex = 53;
            this.textBoxPodaciOVlasniku.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(836, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 17);
            this.label14.TabIndex = 56;
            this.label14.Text = "Boja:";
            // 
            // textBoxBoja
            // 
            this.textBoxBoja.Location = new System.Drawing.Point(882, 132);
            this.textBoxBoja.Name = "textBoxBoja";
            this.textBoxBoja.Size = new System.Drawing.Size(292, 22);
            this.textBoxBoja.TabIndex = 55;
            this.textBoxBoja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Marka:";
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(113, 97);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(242, 22);
            this.textBoxMarka.TabIndex = 57;
            this.textBoxMarka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Vozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 629);
            this.Controls.Add(this.tabControl1);
            this.Name = "Vozilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vozilo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVozila)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBRSasije;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxBRMotora;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxGodinaProizvodnje;
        private System.Windows.Forms.TextBox textBoxRGBR;
        private System.Windows.Forms.DataGridView dataGridViewVozila;
        private System.Windows.Forms.ComboBox comboBoxVlasnik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKubikaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGorivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTIP;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPodaciOVlasniku;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxBoja;
    }
}