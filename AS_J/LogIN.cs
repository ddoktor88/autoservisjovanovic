using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;
namespace AS_J
{
    public partial class LogIN : Form
    {
      /*  private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }*/
        DBBroker db = new DBBroker();
        bool licenced = false;
        public LogIN()
        {
            InitializeComponent();
            ucitajRadnike();
            string modelNo = identifier("Win32_DiskDrive", "Model").Trim();
            //string manufatureID = identifier("Win32_DiskDrive", "Manufacturer");
            string signature = identifier("Win32_DiskDrive", "Signature").Trim();
            //string totalHeads = identifier("Win32_DiskDrive", "TotalHeads");
            string[] licence = new string[2];
            try
            {
                licence = File.ReadAllLines(@"C:\Windows\licmi\lic.txt");
                textBoxInfo.Text = modelNo + "" + signature;// +" " + manufatureID + " " + totalHeads;
                string godina = DateTime.Now.Year.ToString();
                if (textBoxInfo.Text == licence[0] && licence[1] == godina)
                {
                    licenced = true;
                    Program.licencedYear = int.Parse(godina);
                }
                else
                {
                    TextWriter tw = new StreamWriter(@"C:\Windows\licmi\lic.txt");
                    tw.WriteLine("Error.");
                    tw.Close();
                }
            }
            catch (Exception exx)
            {
            }
         
        }
        private void ucitajRadnike()
        {
            comboBoxRadnici.Items.Clear();
            string ret = db.vratiRadnike();
            string[] vlasnici = ret.Split(',');
            foreach (string item in vlasnici)
            {
                if (item.Contains("-"))
                {
                    comboBoxRadnici.Items.Add(item);
                }
            }
            comboBoxRadnici.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Program.ulogovanKorisnik = string.Empty;
            Program.privilege = "User";
            if (true)
            {
                string[] username = comboBoxRadnici.Text.Split('-');
                bool login = db.vratiRadnike(int.Parse(username[0]), textBoxLozinka.Text);
                if (login)
                {
                    Program.ulogovanKorisnik = comboBoxRadnici.Text;
                    Program.privilege = username[2];
                    MessageBox.Show("Uspešno ste se ulogovali u sistem.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    Program.ulogovanKorisnik = string.Empty;
                    MessageBox.Show("Pogrešna lozinka.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //labelInfo.Text = "Pogrešna lozinka !";
                }
            }
            else
            {
                MessageBox.Show("Vaša licenca je istekla. Molimo Vas kontaktirajte proizvodjača za dobijanje nove licence.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.IzadjiIzSistema = true;
            this.Close();
        }

        private string identifier(string wmiClass, string wmiProperty)
        //Return a hardware identifier
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                //Only get the first one
                if (result == "")
                {
                    try
                    {
                        result = mo[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
            }
            return result;
        }

        private void comboBoxRadnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.ulogovanKorisnik = string.Empty;
        }
    }
}
