using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AS_J
{
    public partial class Usluga : Form
    {
        DBBroker db = new DBBroker();
        int selectedID = 0;
        public Usluga()
        {
            InitializeComponent();
            db.napuniGrid("SELECT * from usluga", dataGridViewUsluga);
            db.napuniGrid("SELECT * FROM uslugaartikal", dataGridViewUslugaDeo);
           /* dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Width = 450;
            dataGridView1.Columns[3].Width = 150;*/
            ucitajUsluge();
            ucitajDelove();
        }

        private void ucitajDelove()
        {
            comboBoxSifraArtikla.Items.Clear();
            string ret = db.vratiDelove();
            string[] vlasnici = ret.Split(',');
            foreach (string item in vlasnici)
            {
                if (item.Contains("-"))
                {
                    comboBoxSifraArtikla.Items.Add(item);
                }
            }
           if(comboBoxSifraArtikla.Items.Count>0) comboBoxSifraArtikla.SelectedIndex = 0;
        }
        private void ucitajUsluge()
        {
            comboBoxSifraUsluge.Items.Clear();
            string ret = db.vratiUsluge();
            string[] vlasnici = ret.Split(',');
            foreach (string item in vlasnici)
            {
                if (item.Contains("-"))
                {
                    comboBoxSifraUsluge.Items.Add(item);
                }
            }
            if (comboBoxSifraUsluge.Items.Count > 0) comboBoxSifraUsluge.SelectedIndex = 0;
        }
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            string values = "'" + textBoxSifra.Text + "','" + textBoxNaziv.Text + "','" + textBoxCena.Text + "'";
            string upit = "INSERT INTO usluga (sifra,naziv,cenapozapocetomsatu) VALUES (" + values + ")";

            string desc = "unos nove usluge.";
            string tabela = "usluga";
            Program.insertInLogFile(desc);
            bool istina = db.sacuvajIzmeniObrisiObjekat(upit);
            if (istina)
            {
                MessageBox.Show(desc + " OK. \n" + values);
                Program.insertInLogFile(desc);
                db.napuniGrid("SELECT * FROM " + tabela + "", dataGridViewUsluga);
            }
            else
            {
                MessageBox.Show(desc + " Error.");
                Program.insertInLogFile(desc + " Error.");
            }
            selectedID = 0;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            db.napuniGrid("SELECT * FROM usluga where sifra LIKE '" + textBoxSifra.Text + "' OR naziv LIKE '" + textBoxNaziv.Text + "'", dataGridViewUsluga);
        }

        private void dataGridViewUsluga_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowi = e.RowIndex;
            selectedID = int.Parse(dataGridViewUsluga[0, rowi].Value.ToString());
            textBoxSifra.Text = dataGridViewUsluga[1, rowi].Value.ToString();
            textBoxNaziv.Text = dataGridViewUsluga[2, rowi].Value.ToString();
            textBoxCena.Text = dataGridViewUsluga[3, rowi].Value.ToString();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            string desc = "izmena usluge.";
            string tabela = "usluga";
            Program.insertInLogFile(desc);
            string values = "sifra ='" + textBoxSifra.Text + "',naziv='" + textBoxNaziv.Text + "',cena_po_zapocetom_satu='" + textBoxCena.Text + "'";
            string upit = "UPDATE "+tabela+" SET "+values+" WHERE ID=" + selectedID;
            bool istina = db.sacuvajIzmeniObrisiObjekat(upit);
            if (istina)
            {
                MessageBox.Show(desc+ " OK. \n" + values);
                Program.insertInLogFile(desc);
                db.napuniGrid("SELECT * FROM "+tabela+"", dataGridViewUsluga);
            }
            else
            {
                MessageBox.Show(desc+" Error.");
                Program.insertInLogFile(desc + " Error.");
            }
            selectedID = 0;
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            string values = "'" + textBoxSifra.Text + "','" + textBoxNaziv.Text + "','" + textBoxCena.Text + "'";
            string upit = "DELETE FROM usluga WHERE ID=" + selectedID;
            string desc = "brisanje usluge.";
            string tabela = "usluga";
            Program.insertInLogFile(desc);
              bool istina = db.sacuvajIzmeniObrisiObjekat(upit);
            if (istina)
            {
                MessageBox.Show(desc + " OK. \n" + values);
                Program.insertInLogFile(desc);
                db.napuniGrid("SELECT * FROM " + tabela + "", dataGridViewUsluga);
            }
            else
            {
                MessageBox.Show(desc + " Error.");
                Program.insertInLogFile(desc + " Error.");
            }
            selectedID = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string values = "'" + comboBoxSifraUsluge.Text + "','" + comboBoxSifraArtikla.Text + "'";
            string upit = "INSERT INTO uslugaartikal (sifrausluge,ID_artikla) VALUES (" + values + ")";

            string desc = "unos novog usluga + deo.";
            string tabela = "uslugaartikal";
            Program.insertInLogFile(desc);
            bool istina = db.sacuvajIzmeniObrisiObjekat(upit);
            if (istina)
            {
                MessageBox.Show(desc + " OK. \n" + values);
                Program.insertInLogFile(desc);
                db.napuniGrid("SELECT * FROM " + tabela + "", dataGridViewUslugaDeo);
            }
            else
            {
                MessageBox.Show(desc + " Error.");
                Program.insertInLogFile(desc + " Error.");
            }
            selectedID = 0;
        }
    }
}
