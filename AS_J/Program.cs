using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
namespace AS_J
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        public static string ulogovanKorisnik = "";
        public static bool IzadjiIzSistema = false;
        public static int licencedYear = 0;
        public static string privilege = "User";
        public static void insertInLogFile(string poruka)
        {
            string time = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
            string date = DateTime.Now.Day.ToString("D2") + "." + DateTime.Now.Month.ToString("D2") + "." + (DateTime.Now.Year - 2000).ToString("D2");

            try
            {
                using (StreamWriter writer = File.AppendText(@"C:\test\LOGdb.txt"))
                {
                    writer.WriteLine(date + "  " + time + " *** " + poruka);
                    writer.Close();
                }
            }

            catch (Exception) { }
            finally { }
        }
    }
}
