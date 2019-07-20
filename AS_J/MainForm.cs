using System;

using System.Collections;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Text;

using System.Windows.Forms;

using iTextSharp;

using iTextSharp.text;

using iTextSharp.text.pdf;

using iTextSharp.text.xml;
using CelikNET;
using System.IO; 
namespace AS_J
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           
            ListFieldNames();
            //FillForm();
            pictureBoxLogo.Visible = false;
            timer1.Enabled = true;
            timer1.Start();
        }
        
        private void ListFieldNames()
        {


            /*


            string pdfTemplate = @"c:\test\RadniNalogT.pdf";

            // title the form

           

            // create a new PDF reader based on the PDF template document

            PdfReader pdfReader = new PdfReader(pdfTemplate);
          //  AcroFields pdfFormFields = pdfReader.AcroFields;
        
            // create and populate a string builder with each of the

            // field names available in the subject PDF

            StringBuilder sb = new StringBuilder();

            foreach (var de in pdfReader.AcroFields.Fields)
            {
                sb.Append(de.Key.ToString() + Environment.NewLine);
            }
            // Write the string builder's content to the form's textbox
            this.Text = sb.ToString();
            // textBox1.SelectionStart = 0;
             * */

        }

        private void FillForm()
        {

            string pdfTemplate = @"c:\test\RadniNalogT.pdf";

            string newFile = @"c:\test\milosNew.pdf";

            PdfReader pdfReader = new PdfReader(pdfTemplate);

            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));

            AcroFields pdfFormFields = pdfStamper.AcroFields;

            // set form pdfFormFields

            // The first worksheet and W-4 form

            pdfFormFields.SetField("Ime", "Milos");

            pdfFormFields.SetField("Prezime", "Ivanovic");
            // report by reading values from completed PDF

            string sTmp = "W-4 Completed for " + pdfFormFields.GetField("f1_09(0)") + " " + pdfFormFields.GetField("f1_10(0)");

            //MessageBox.Show(sTmp, "Finished");



            // flatten the form to remove editting options, set it to false

            // to leave the form open to subsequent manual edits

            pdfStamper.FormFlattening = false;



            // close the pdf

            pdfStamper.Close();

        } 
        private void button1_Click(object sender, EventArgs e)
        {
            VlasniciVozila vv = new VlasniciVozila();
            vv.ShowDialog();
        }
        bool ulogovan = false;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (!ulogovan)
            {
                timer1.Interval = 200;
                labelDatumVreme.Text = ".....";
                timer1.Enabled = false;
                timer1.Stop();
                this.Opacity = 0.6;
                ulogovanKorisnikToolStripMenuItem.Text = "Ulogovan korisnik: ";
                pictureBoxLogo.Visible = false;
                LogIN lg = new LogIN();
                lg.ShowDialog();
                if (Program.ulogovanKorisnik != string.Empty)
                {
                    ulogovan = true;
                    
                }
                this.Opacity = 1;
                ulogovanKorisnikToolStripMenuItem.Text = "Ulogovan korisnik: " + Program.ulogovanKorisnik;
                pictureBoxLogo.Visible = true;
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
               // if (Program.privilege == "Admin") { buttonRadnici.Visible = true;  } else { buttonRadnici.Visible = false; }
                timer1.Interval = 1000;
                string time = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
                string date = DateTime.Now.Day.ToString("D2") + "." + DateTime.Now.Month.ToString("D2") + "." + (DateTime.Now.Year).ToString("D4");
                labelDatumVreme.Text = date + " " + time;
            }
            if (DateTime.Now.Year != 2019) this.Close();
            if (Program.IzadjiIzSistema) this.Close();
            if (Program.ulogovanKorisnik == string.Empty) this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vozilo v = new Vozilo();
            v.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.privilege == "Admin")
            {
                Majstori m = new Majstori();
                m.ShowDialog();
            }
            else
            {
                MessageBox.Show("Administrator može otvoriti ovu opciju. Vi nemate ovu privilegiju.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Usluga u = new Usluga();
            u.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Magacin mmm = new Magacin();
            mmm.ShowDialog();
        }

        private void odjaviSeIzSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ulogovan = false;
            Program.ulogovanKorisnik = string.Empty;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Dobavljac d = new Dobavljac();
            d.ShowDialog();
        }
    }
}
