using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;
namespace AS_J
{
    class DBBroker
    {

        MySqlConnection conncomm;
        string server;
        string database;
        string uid;
        string password;

        public DBBroker()
        {
            try
            {
                string[] allLines = File.ReadAllLines(@"C:\test\db.txt");
                server = allLines[0];
                database = allLines[1];
                uid = allLines[2];
                password = allLines[3];
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "Pooling=false";
                conncomm = new MySqlConnection(connectionString);
            }
            catch (Exception exx) { }
            finally { }
        }

        public void napuniGrid(string upit, DataGridView dataGridView1)
        {
            DataSet ds = new DataSet();
            try
            {
                dataGridView1.DataSource = null;
                MySqlCommand ocomm = new MySqlCommand();
                ocomm.Connection = conncomm;
                ocomm.CommandText = upit;
                if (conncomm.State == ConnectionState.Closed) conncomm.Open();
                MySqlDataAdapter oda = new MySqlDataAdapter(ocomm);
                MySqlCommandBuilder ocb = new MySqlCommandBuilder(oda);
                oda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
                oda.Dispose();

                
            }
            catch (Exception exx) { Program.insertInLogFile("" + exx.Message); }
            finally { if (conncomm.State == ConnectionState.Open)conncomm.Close(); }
        }
        public bool sacuvajIzmeniObrisiObjekat(string upit)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = upit;
                cmd.Connection = conncomm;
                if (conncomm.State == ConnectionState.Closed) conncomm.Open();
                cmd.ExecuteNonQuery();
                if (conncomm.State == ConnectionState.Open) conncomm.Close();
                Program.insertInLogFile(" sacuvan/izmeni/obrisi objekat. " + upit);
                return true;
            }
            catch (Exception exx)
            {
                Program.insertInLogFile(" greska pri sacuvaj/izmeni/obrisi objekat. "+upit +" : " + exx.Message);
            }
            return false;
        }
        public string vratiVlasnike()
        {
            string ret = "";
            string upit = "SELECT * from pravnolice";
          //  if (conncomm.State == ConnectionState.Closed) conncomm.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                upit = "SELECT * from pravnolice";
                cmd.CommandText = upit;
                cmd.Connection = conncomm;
                if (conncomm.State == ConnectionState.Closed) conncomm.Open();
                MySqlDataReader odr = cmd.ExecuteReader();
                while (odr.Read())
                {
                    ret = ret + "," + odr.GetInt32(0).ToString();
                    ret = ret + "-" + odr.GetString(1);
                }
                if (conncomm.State == ConnectionState.Open) conncomm.Close();
                Program.insertInLogFile(" vracanje vlasnika. " + upit);
            }
            catch (Exception exx)
            {
                Program.insertInLogFile(" greska pri vracanju vlasnika. " + upit + " : " + exx.Message);
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                upit = "SELECT * from fizickolice";
                cmd.CommandText = upit;
                cmd.Connection = conncomm;
                if (conncomm.State == ConnectionState.Closed) conncomm.Open();
                MySqlDataReader odr = cmd.ExecuteReader();
                while (odr.Read())
                {
                    ret = ret + ","+ odr.GetInt32(0).ToString();
                    ret = ret + "-" + odr.GetString(1) + " " + odr.GetString(2);
                }
                if (conncomm.State == ConnectionState.Open) conncomm.Close();
                Program.insertInLogFile(" vracanje vlasnika. " + upit);
            }
            catch (Exception exx)
            {
                Program.insertInLogFile(" greska pri vracanju vlasnika. " + upit + " : " + exx.Message);
            }
           // if (conncomm.State == ConnectionState.Open) conncomm.Close();
            return ret;
        }

        public string vratiUsluge()
        {
            string ret = "";
            string upit = "SELECT * from usluga";
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = upit;
                cmd.Connection = conncomm;
                if (conncomm.State == ConnectionState.Closed) conncomm.Open();
                MySqlDataReader odr = cmd.ExecuteReader();
                while (odr.Read())
                {
                    ret = ret + "," + odr.GetString(1);
                    ret = ret + "-" + odr.GetString(2);
                }
                if (conncomm.State == ConnectionState.Open) conncomm.Close();
                Program.insertInLogFile(" vracanje usluga. " + upit);
            }
            catch (Exception exx)
            {
                Program.insertInLogFile(" greska pri vracanju usluga. " + upit + " : " + exx.Message);
            }
            return ret;
        }
        public string vratiDelove()
        {
            string ret = "";
            string upit = "SELECT * from magacin";
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = upit;
                cmd.Connection = conncomm;
                if (conncomm.State == ConnectionState.Closed) conncomm.Open();
                MySqlDataReader odr = cmd.ExecuteReader();
                while (odr.Read())
                {
                    ret = ret + "," + odr.GetString(1);
                    ret = ret + "-" + odr.GetString(2);
                }
                if (conncomm.State == ConnectionState.Open) conncomm.Close();
                Program.insertInLogFile(" vracanje delova. " + upit);
            }
            catch (Exception exx)
            {
                Program.insertInLogFile(" greska pri vracanju delova. " + upit + " : " + exx.Message);
            }
            return ret;
        }
        public string vratiRadnike()
        {
            string ret = "";
            string upit = "SELECT * from majstori";
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = upit;
                cmd.Connection = conncomm;
                if (conncomm.State == ConnectionState.Closed) conncomm.Open();
                MySqlDataReader odr = cmd.ExecuteReader();
                while (odr.Read())
                {
                    ret = ret + "," + odr.GetInt32(0);
                    ret = ret + "-" + odr.GetString(1) +" "+ odr.GetString(2);
                    ret = ret + "-" + odr.GetString(8);
                }
                if (conncomm.State == ConnectionState.Open) conncomm.Close();
                Program.insertInLogFile(" vracanje radnika. " + upit);
            }
            catch (Exception exx)
            {
                Program.insertInLogFile(" greska pri vracanju radnika. " + upit + " : " + exx.Message);
            }
            return ret;
        }
        public bool vratiRadnike(int id,string password)
        {
            bool ret = false;
            string upit = "SELECT * from majstori where ID = "+id+" and lozinka = '"+password+"'";
            int numOfRec = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = upit;
                cmd.Connection = conncomm;
                if (conncomm.State == ConnectionState.Closed) conncomm.Open();
                MySqlDataReader odr = cmd.ExecuteReader();

                while (odr.Read())
                {
                    numOfRec++;
                }
                if (conncomm.State == ConnectionState.Open) conncomm.Close();
                Program.insertInLogFile(" provera radnika. " + upit);
            }
            catch (Exception exx)
            {
                Program.insertInLogFile(" greska pri proveri radnika. " + upit + " : " + exx.Message);
            }
            if (numOfRec == 1) ret = true;
            return ret;
        }
    }
}
