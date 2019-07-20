using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CelikNET;
namespace AS_J
{
    public partial class VlasniciVozila : Form
    {
        DBBroker db = new DBBroker();
        int selectedID = 0;
        public VlasniciVozila()
        {
            InitializeComponent();
            db.napuniGrid("SELECT * FROM fizickolice", dataGridViewFizickaLica);
            db.napuniGrid("SELECT * FROM pravnolice", dataGridViewPravnaLica);
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
          Program.insertInLogFile("sacuvaj fizicko lice.");
          string upit = "INSERT INTO fizickolice (Prezime,Ime,JMBG,BrLkKarte,Mesto,Adresa,Telefon1,Telefon2,email) VALUES('" + textBoxPrezime.Text + "','" + textBoxIme.Text + "','" + textBoxJMBG.Text + "','" + textBoxBRLK.Text + "','" + textBoxMesto.Text + "','" + textBoxAdresa.Text + "','" + textBoxTelefon1.Text + "','" + textBoxTelefon2.Text + "','" + textBoxEmail.Text + "')";
          bool istina=  db.sacuvajIzmeniObrisiObjekat(upit);
          if (istina)
          {
              MessageBox.Show("Uspešno ste sačuvali novo fizičko lice.");
              Program.insertInLogFile("sacuvano novo fizicko lice.");
          }
          else
          {
              MessageBox.Show("Greska.");
              Program.insertInLogFile("greska pri cuvanju fizickog lica.");
          }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          DialogResult dr =  MessageBox.Show("Da li ste proverili da ste ubacili ličnu kartu u čitač i da je čitač aktivan ? \n\n Nakon aktiviranja ove opcije potrebno je sacekati par sekundi.","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
          if (dr == System.Windows.Forms.DialogResult.Yes)
          {
              Program.insertInLogFile(" je odabrao opciju citac licne karte.");
              //this.Text = readLK();
              timerCitacKartice.Start();
          }
        }
        private string readLK()
        {
            string retV = string.Empty;
            using (CelikNET.CelikInterop x = new CelikNET.CelikInterop())
            {
                try
                {
                    try
                    {
                        Console.WriteLine("Podaci o licnoj karti ------------------------------------------");
                        CelikNET.DocumentData d3 = x.ReadDocumentData();
                        textBoxBRLK.Text = d3.docRegNo;
                        /* Console.WriteLine("docRegNo: {0}", d3.docRegNo);
                         Console.WriteLine("issuingDate: {0}", d3.issuingDate);
                         Console.WriteLine("expiryDate: {0}", d3.expiryDate);
                         Console.WriteLine("issuingAuthority: {0}", d3.issuingAuthority);*/
                    }
                    catch (Exception) { }
                    try{
                    Console.WriteLine("Fiksni podaci ------------------------------------------");
                    CelikNET.FixedPersonalData d1 = x.ReadFixedPersonalData();
                    // Console.WriteLine("personalNumber: {0}", d1.personalNumber);
                    textBoxPrezime.Text= d1.surname.ToUpper();
                    // Console.WriteLine("surname: {0}", d1.surname);
                    textBoxIme.Text= d1.givenName.ToUpper();
                    textBoxJMBG.Text= d1.personalNumber;
                    }
                    catch (Exception) { }
                    try{
                    Console.WriteLine("Variabilni podaci ------------------------------------------");
                    CelikNET.VariablePersonalData d2 = x.ReadVariablePersonalData();
                    //textBoxMesto.Text= d2.state;
                    textBoxMesto.Text = d2.place;
                    textBoxAdresa.Text = d2.street + " " + d2.houseNumber + " " + d2.houseLetter;
                    }
                    catch (Exception) { }
                    // Bitmap c = x.ReadProfileImage();
                  
                    Console.WriteLine(retV);
                }
                catch (Exception exx)
                {
                    //MessageBox.Show("Greška pri čitanju lične karte (oštećen čip, greška u komunikaciji, oštećen čitač itd.)");
                }
                finally {  }
                
            }
            return retV;
        }

        private void dataGridViewPravnaLica_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRow = e.RowIndex;
            selectedID = int.Parse(dataGridViewPravnaLica[0, selectedRow].Value.ToString());
            textBoxNaziv.Text = dataGridViewPravnaLica[1, selectedRow].Value.ToString();
            textBoxPIB.Text = dataGridViewPravnaLica[2, selectedRow].Value.ToString();
            textBoxKontaktLice.Text = dataGridViewPravnaLica[3, selectedRow].Value.ToString();
            textBoxPLMesto.Text = dataGridViewPravnaLica[4, selectedRow].Value.ToString();
            textBoxPLAdresa.Text = dataGridViewPravnaLica[5, selectedRow].Value.ToString();
            textBoxPLTelefon1.Text = dataGridViewPravnaLica[6, selectedRow].Value.ToString();
            textBoxPLTelefon2.Text = dataGridViewPravnaLica[7, selectedRow].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedID = 0;
            Program.insertInLogFile("sacuvaj pravno lice.");
            string upit = "INSERT INTO pravnolice (Naziv,PIB,LiceZaKontakt,Mesto,Adresa,Telefon1,Telefon2) VALUES('" + textBoxNaziv.Text + "','" + textBoxPIB.Text + "','" + textBoxKontaktLice.Text + "','" + textBoxPLMesto.Text + "','" + textBoxPLAdresa.Text + "','" + textBoxPLTelefon1.Text + "','" + textBoxPLTelefon2.Text + "')";
            bool istina = db.sacuvajIzmeniObrisiObjekat(upit);
            if (istina)
            {
                MessageBox.Show("Uspešno ste sačuvali novo pravno lice.");
                Program.insertInLogFile("sacuvano novo pravno lice.");
                db.napuniGrid("SELECT * FROM pravnolice", dataGridViewPravnaLica);
            }
            else
            {
                MessageBox.Show("Greska.");
                Program.insertInLogFile("greska pri cuvanju pravnog lica.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Program.insertInLogFile("izmeni pravno lice.");
            string upit = "UPDATE pravnolice SET    WHERE ID="+selectedID;
            bool istina = db.sacuvajIzmeniObrisiObjekat(upit);
            if (istina)
            {
                MessageBox.Show("Uspešno ste izmenili pravno lice.");
                Program.insertInLogFile("sacuvane izmene pravnog lica.");
                db.napuniGrid("SELECT * FROM pravnolice", dataGridViewPravnaLica);
            }
            else
            {
                MessageBox.Show("Greska.");
                Program.insertInLogFile("greska pri izmeni pravnog lica.");
            }

            selectedID = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.insertInLogFile("obrisi pravno lice.");
            string upit = "DELETE FROM pravnolice WHERE ID="+selectedID;
            bool istina = db.sacuvajIzmeniObrisiObjekat(upit);
            if (istina)
            {
                MessageBox.Show("Uspešno ste obrisali pravno lice.");
                Program.insertInLogFile("obrisano pravno lice.");
                db.napuniGrid("SELECT * FROM pravnolice", dataGridViewPravnaLica);
            }
            else
            {
                MessageBox.Show("Greska.");
                Program.insertInLogFile("greska pri brisanju pravnog lica.");
            }

            selectedID = 0;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            db.napuniGrid("SELECT * FROM pravnolice where naziv LIKE '"+textBoxNaziv.Text+"' OR PIB LIKE '"+textBoxPIB.Text+"'", dataGridViewPravnaLica);
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {

        }
        int brojCitanja = 0;
        private void timerCitacKartice_Tick(object sender, EventArgs e)
        {
            timerCitacKartice.Interval = 200;
           
            brojCitanja++;
            button1.Text = "Čitanje: " + brojCitanja.ToString();
            readLK();
            if (brojCitanja >= 10) { timerCitacKartice.Stop(); brojCitanja = 0; button1.Text = "Čitač lične karte"; }
        }
    }
}
