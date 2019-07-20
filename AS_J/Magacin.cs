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
    public partial class Magacin : Form
    {
        DBBroker db = new DBBroker();
        int selectedID = 0;
        public Magacin()
        {
            //first commit
            InitializeComponent();
            comboBoxJedinicaMere.SelectedIndex = 0;
            textBoxDatumIzmene.Text = DateTime.Now.ToShortDateString();
            db.napuniGrid("SELECT * FROM magacin", dataGridViewMagacin);
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            string values = "'" + textBoxSifra.Text + "','" + textBoxNaziv.Text + "','" + textBoxKolicina.Text + "','" + textBoxCena.Text + "','" + textBoxDatumIzmene.Text + "'";
            string upit = "INSERT INTO magacin (sifraArtikla,nazivArtikla,Kolicina,Cena,PoslednjaIzmenaArtikla) VALUES(" + values + ")";
            string desc = "unos artikla.";
            string tabela = "magacin";
            bool istina = db.sacuvajIzmeniObrisiObjekat(upit);
            if (istina)
            {
                MessageBox.Show(desc + " OK. \n" + values);
                Program.insertInLogFile(desc);
                db.napuniGrid("SELECT * FROM " + tabela + "", dataGridViewMagacin);
            }
            else
            {
                MessageBox.Show(desc + " Error.");
                Program.insertInLogFile(desc + " Error.");
            }
            selectedID = 0;
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            string desc = "izmena artikla.";
            string tabela = "magacin";
            Program.insertInLogFile(desc);
            string values = "sifraArtikla='" + textBoxSifra.Text + "',nazivArtikla='" + textBoxNaziv.Text + "',Kolicina='" + textBoxKolicina.Text + "',Cena='" + textBoxCena.Text + "',PoslednjaIzmenaArtikla='" + textBoxDatumIzmene.Text + "'";
            //string upit = "INSERT INTO majstori (ime,prezime,telefon,korisnickoime,lozinka,email,radnomesto) VALUES(" + values + ")";
            string upit = "UPDATE " + tabela + " SET " + values + " WHERE ID=" + selectedID;
            bool istina = db.sacuvajIzmeniObrisiObjekat(upit);
            if (istina)
            {
                MessageBox.Show(desc + " OK. \n" + values);
                Program.insertInLogFile(desc);
                db.napuniGrid("SELECT * FROM " + tabela + "", dataGridViewMagacin);
            }
            else
            {
                MessageBox.Show(desc + " Error.");
                Program.insertInLogFile(desc + " Error.");
            }
            selectedID = 0;
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            string desc = "brisanje artikla.";
            string tabela = "magacin";
            Program.insertInLogFile(desc);
            string upit = "DELETE FROM " + tabela + " WHERE ID=" + selectedID;
            bool istina = db.sacuvajIzmeniObrisiObjekat(upit);
            if (istina)
            {
                MessageBox.Show(desc + " OK. \n" + upit);
                Program.insertInLogFile(desc);
                db.napuniGrid("SELECT * FROM " + tabela + "", dataGridViewMagacin);
            }
            else
            {
                MessageBox.Show(desc + " Error.");
                Program.insertInLogFile(desc + " Error.");
            }
            selectedID = 0;
        }

        private void dataGridViewMagacin_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            selectedID = int.Parse(dataGridViewMagacin[0, rowindex].Value.ToString());
            textBoxSifra.Text = dataGridViewMagacin[1, rowindex].Value.ToString();
            textBoxNaziv.Text = dataGridViewMagacin[2, rowindex].Value.ToString();
            textBoxKolicina.Text = dataGridViewMagacin[3, rowindex].Value.ToString();
            textBoxCena.Text = dataGridViewMagacin[4, rowindex].Value.ToString();
            textBoxDatumIzmene.Text = dataGridViewMagacin[5, rowindex].Value.ToString();
         }
    }
}
