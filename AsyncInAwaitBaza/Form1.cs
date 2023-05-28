using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace AsyncInAwaitBaza
{
    
    public partial class okno : Form
    {
        private String povezovalniNiz = "Server= baza.fmf.uni-lj.si; User Id= student11; Password= student; Database= nobel2012;";
        public okno()
        {
            InitializeComponent();
        }

        private async void Isci(object sender, EventArgs e)
        {
            rezultat.Text = "";
            NpgsqlConnection povezava = new NpgsqlConnection(povezovalniNiz);
            String sqlUkaz = $"Select * FROM Nobel WHERE subject = '{podrocjeComboBox.Text}'";
            NpgsqlCommand ukaz = new NpgsqlCommand(sqlUkaz, povezava);

            await Task.Delay(5000);
            await povezava.OpenAsync();
            NpgsqlDataReader kurzor = await ukaz.ExecuteReaderAsync();

            while (await kurzor.ReadAsync())
            {
                string področje = kurzor["subject"].ToString();
                string leto = kurzor["yr"].ToString();
                string dobitnik = kurzor["winner"].ToString();
                string podr = področje;
                rezultat.AppendText(String.Format("* {0} {1} {2}.", leto, podr, dobitnik));
                rezultat.AppendText(Environment.NewLine);
                }
            }

        private void OknoNalozi(object sender, EventArgs e)
        {
            NpgsqlConnection povezava = new NpgsqlConnection(povezovalniNiz);
            povezava.Open();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT DISTINCT subject FROM nobel", povezava);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            podrocjeComboBox.DisplayMember = "subject";
            podrocjeComboBox.DataSource = dt;
            povezava.Close();

        }
    }
    }

