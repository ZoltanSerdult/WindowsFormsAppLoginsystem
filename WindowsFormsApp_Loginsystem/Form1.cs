using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp_Loginsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Be_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Nem irt be nevet");
                return;
            }
            if (string.IsNullOrEmpty(textBox_jelszo.Text))
            {
                MessageBox.Show("Nem irt be jelszót");
                return;
            }
            string inputFelh = textBox_nev.Text;
            string inputJelszo = textBox_jelszo.Text;

            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "login";
            sb.CharacterSet = "UTF8";
            MySqlConnection con = new MySqlConnection(sb.ToString());
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT `user`, `password` FROM `login` WHERE 1;";
                con.Open();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string felh = dr.GetString("user");
                        string jelszo = dr.GetString("password");

                        if (inputFelh == felh && inputJelszo == jelszo)
                        {
                            label_allapot.Text = "BEJELENKEZVE";
                            label_allapot.ForeColor = Color.Green;
                            button_Be.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Rossz adatot adott meg","FIGYELMEZTETÉS");
                            label_allapot.Text = "ELUTASITVA";
                            label_allapot.ForeColor = Color.Red;
                            return;
                        }

                        // listBox_jelenit.Items.Add($"Felhasználó {felh} Jelszó {jelszo}");
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"{ex}", "HIBA");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "login";
            sb.CharacterSet = "UTF8";
            MySqlConnection con = new MySqlConnection(sb.ToString());
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT `user`, `password` FROM `login` WHERE 1;";
                con.Open();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string felh = dr.GetString("user");
                        string jelszo = dr.GetString("password");

                        listBox_jelenit.Items.Add($"Felhasználó {felh} Jelszó {jelszo}");
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"{ex}", "HIBA");
            }
        }
    }
}
