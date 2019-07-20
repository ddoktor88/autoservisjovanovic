using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eVehicleRegistrationCOM;
namespace AS_J
{
    public partial class Vozilo : Form
    {
        DBBroker db = new DBBroker();
        int selectedID = 0;
        public Vozilo()
        {
            InitializeComponent();
            ucitajVlasnike();
            db.napuniGrid("SELECT * FROM vozilo", dataGridViewVozila);
        }

        private void ucitajVlasnike()
        {
            comboBoxVlasnik.Items.Clear();
            string ret = db.vratiVlasnike();
            string[] vlasnici = ret.Split(',');
            foreach (string item in vlasnici)
            {
                if (item.Contains("-"))
                {
                    comboBoxVlasnik.Items.Add(item);
                }
            }
            comboBoxVlasnik.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string values = "'" + textBoxTIP.Text + "','" + textBoxRGBR.Text + "','" + textBoxBoja.Text + "','" + textBoxGodinaProizvodnje.Text + "','" + textBoxModel.Text + "','" + textBoxBRMotora.Text + "','" + textBoxGorivo.Text + "','" + textBoxKubikaza.Text + "','" + textBoxBRSasije.Text + "','" + comboBoxVlasnik.Text + "','" + textBoxPodaciOVlasniku.Text + "'";
            string upit = "INSERT INTO vozilo (TIP,RGBR,Godina,Boja,Model,BrojMotora,Gorivo,Kubikaza,brojSasije,Vlasnik,Podaci_O_Vlasniku) VALUES(" + values + ")";

            string desc = "unos novog vozila.";
            string tabela = "vozilo";
            Program.insertInLogFile(desc);
            bool istina = db.sacuvajIzmeniObrisiObjekat(upit);
            if (istina)
            {
                MessageBox.Show(desc + " OK. \n" + values);
                Program.insertInLogFile(desc);
                db.napuniGrid("SELECT * FROM " + tabela + "", dataGridViewVozila);
            }
            else
            {
                MessageBox.Show(desc + " Error.");
                Program.insertInLogFile(desc + " Error.");
            }
            selectedID = 0;
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VlasniciVozila vv = new VlasniciVozila();
            vv.ShowDialog();
            ucitajVlasnike();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Registration rc = new Registration();
                string readerName = "Gemalto USB Smart Card Reader 0";
                eVehicleRegistrationCOM._VEHICLE_DATA vozilo = new _VEHICLE_DATA();
                eVehicleRegistrationCOM._PERSONAL_DATA personel = new _PERSONAL_DATA();
                rc.Initialize();
                rc.GetReaderName(0, out readerName);
                rc.SelectReader(readerName);
                rc.ProcessNewCard();
                rc.ReadVehicleData(out vozilo);
                rc.ReadPersonalData(out personel);
                if (rc != null && vozilo.registrationNumberOfVehicle != null && personel.ownerAddress != null)
                {
                    /*retV = vozilo.registrationNumberOfVehicle.Trim() + "," + vozilo.vehicleCategory + "," + vozilo.yearOfProduction + "," + vozilo.colourOfVehicle + "," + vozilo.commercialDescription + "," + vozilo.engineIDNumber + "," +
                        personel.ownersPersonalNo + "," + personel.ownerName + "," + personel.ownersSurnameOrBusinessName + "," + personel.ownerAddress;
                    retV = retV.Replace("\0", "");*/
                    textBoxTIP.Text = vozilo.vehicleCategory.ToString();
                    textBoxBRMotora.Text = vozilo.engineIDNumber.ToString();
                    textBoxBRSasije.Text = vozilo.vehicleIDNumber.ToString();
                    textBoxGodinaProizvodnje.Text = vozilo.yearOfProduction.ToString();
                    textBoxRGBR.Text = vozilo.registrationNumberOfVehicle.ToString();
                    textBoxBoja.Text = vozilo.colourOfVehicle.ToString();
                    textBoxGorivo.Text = vozilo.typeOfFuel.ToString();
                    textBoxKubikaza.Text = vozilo.engineCapacity.ToString();
                    textBoxModel.Text = vozilo.commercialDescription;
                    textBoxMarka.Text = vozilo.vehicleType;
                    string podacivlasnik = personel.ownersPersonalNo + "," + personel.ownerName + "," + personel.ownersSurnameOrBusinessName + "," + personel.ownerAddress;
                    textBoxPodaciOVlasniku.Text = podacivlasnik.Replace("\0", "");
                }
            }
            catch (Exception exx)
            {

            }
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {

        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {

        }
    }
}
