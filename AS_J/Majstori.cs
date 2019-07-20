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
    public partial class Majstori : Form
    {
        DBBroker db = new DBBroker();
        int selectedID = 0;
        public Majstori()
        {
            InitializeComponent();
            db.napuniGrid("SELECT * FROM majstori", dataGridViewMajstori);
        }
        Random r = new Random();
        private void textBoxIme_TextChanged(object sender, EventArgs e)
        {
            textBoxKorisnickoIme.Text = textBoxIme.Text.ToLower() + "." + textBoxPrezime.Text.ToLower();
            textBoxLozinka.Text = r.Next(1000, 9999).ToString();
        }

        private void textBoxPrezime_TextChanged(object sender, EventArgs e)
        {
            textBoxKorisnickoIme.Text = textBoxIme.Text.ToLower() + "." + textBoxPrezime.Text.ToLower();
            textBoxLozinka.Text =  r.Next(1000, 9999).ToString();
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            string values = "'" + textBoxIme.Text + "','" + textBoxPrezime.Text + "','" + textBoxTelefon.Text + "','" + textBoxKorisnickoIme.Text + "','" + textBoxLozinka.Text + "','" + textBoxMail.Text + "','" + textBoxradnoMesto.Text + "'";
            string upit =  "INSERT INTO majstori (ime,prezime,telefon,korisnickoime,lozinka,email,radnomesto) VALUES("+values+")";
            string desc = "unos radnika.";
            string tabela = "majstori";
            bool istina = db.sacuvajIzmeniObrisiObjekat(upit);
            if (istina)
            {
                MessageBox.Show(desc + " OK. \n" + values);
                Program.insertInLogFile(desc);
                db.napuniGrid("SELECT * FROM " + tabela + "", dataGridViewMajstori);
            }
            else
            {
                MessageBox.Show(desc + " Error.");
                Program.insertInLogFile(desc + " Error.");
            }
            selectedID = 0;

        }

        private void dataGridViewMajstori_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            selectedID = int.Parse(dataGridViewMajstori[0, rowindex].Value.ToString());
            textBoxIme.Text = dataGridViewMajstori[1, rowindex].Value.ToString();
            textBoxPrezime.Text = dataGridViewMajstori[2, rowindex].Value.ToString();
            textBoxTelefon.Text = dataGridViewMajstori[3, rowindex].Value.ToString();
            textBoxKorisnickoIme.Text = dataGridViewMajstori[4, rowindex].Value.ToString();
            textBoxMail.Text = dataGridViewMajstori[6, rowindex].Value.ToString();
            textBoxradnoMesto.Text = dataGridViewMajstori[7, rowindex].Value.ToString();
            textBoxLozinka.Text = dataGridViewMajstori[5, rowindex].Value.ToString();

        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            string desc = "izmena radnika.";
            string tabela = "majstori";
            Program.insertInLogFile(desc);
            string values = "ime='" + textBoxIme.Text + "',prezime='" + textBoxPrezime.Text + "',telefon='" + textBoxTelefon.Text + "',korisnickoime='" + textBoxKorisnickoIme.Text + "',lozinka='" + textBoxLozinka.Text + "',email='" + textBoxMail.Text + "',radnomesto='" + textBoxradnoMesto.Text + "'";
            //string upit = "INSERT INTO majstori (ime,prezime,telefon,korisnickoime,lozinka,email,radnomesto) VALUES(" + values + ")";
            string upit = "UPDATE " + tabela + " SET " + values + " WHERE ID=" + selectedID;
            bool istina = db.sacuvajIzmeniObrisiObjekat(upit);
            if (istina)
            {
                MessageBox.Show(desc + " OK. \n" + values);
                Program.insertInLogFile(desc);
                db.napuniGrid("SELECT * FROM " + tabela + "", dataGridViewMajstori);
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
            string desc = "brisanje radnika.";
            string tabela = "majstori";
            Program.insertInLogFile(desc);
             string upit = "DELETE FROM " + tabela + " WHERE ID=" + selectedID;
            bool istina = db.sacuvajIzmeniObrisiObjekat(upit);
            if (istina)
            {
                MessageBox.Show(desc + " OK. \n"+ upit);
                Program.insertInLogFile(desc);
                db.napuniGrid("SELECT * FROM " + tabela + "", dataGridViewMajstori);
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
