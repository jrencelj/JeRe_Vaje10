using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Vaje10
{
    public partial class Okno : Form
    {
        private DataSet ds;
        private SQLiteDataAdapter da;
        private const string povNiz = @"Data Source=../../../../Data/filmi.db; Verison=3;";
        public Okno()
        {
            InitializeComponent();
        }

        private void napolniVsebina()
        {
            SQLiteConnection povezava = new SQLiteConnection(povNiz);
            da = new SQLiteDataAdapter("SELECT * FROM vsebina;", povezava);
            ds = new DataSet();
            da.Fill(ds, "vsebina");
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnCount = 3;
            dataGridView.Columns[0].Name = "id"; 
            dataGridView.Columns[0].HeaderText = "ID"; 
            dataGridView.Columns[0].DataPropertyName = "id"; 

            dataGridView.Columns[1].HeaderText = "naslov";
            dataGridView.Columns[1].Name = "Naslov";
            dataGridView.Columns[1].DataPropertyName = "naslov";

            dataGridView.Columns[2].Name = "leto_izida";
            dataGridView.Columns[2].HeaderText = "Leto izida";
            dataGridView.Columns[2].DataPropertyName = "leto_izida";

            dataGridView.DataSource = ds.Tables["vsebina"];
        }
        private void isci(object sender, MouseEventArgs e)
        {
            if (serije_rb.Checked)
            {
                dataGridView.DataSource = ds.Tables["vsebina"].Select("vsebina_tip_id = 2").CopyToDataTable();
            }
            else if (filmi_rb.Checked)
            {
                dataGridView.DataSource = ds.Tables["vsebina"].Select("vsebina_tip_id = 1").CopyToDataTable();
            }
            else
            {
                MessageBox.Show("Nepravilni podatki!", "Napaka!");
                return;
            }
        }

        private void vsebinaPodrobno(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id;
            DataRow vrstica;
            try
            {
                vrstica = ds.Tables["vsebina"].Rows[e.RowIndex];
                id = vrstica.ItemArray[0].ToString();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return;
            }

            vrstica = ds.Tables["vsebina"].Select($"id = {id}")[0];
            Podrobno podrobno = new Podrobno(id, vrstica["naslov"].ToString(), vrstica["opis"].ToString());
            podrobno.Show();
        }

        private void oknoLoad(object sender, EventArgs e)
        {
            napolniVsebina();
        }
    }
}
