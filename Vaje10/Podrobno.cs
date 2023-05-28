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
namespace Vaje10
{
    public partial class Podrobno : Form
    {
        private string id;
        private string naslov;
        private string opis;
        public Podrobno(string id, string naslov, string opis)
        {
            this.id = id;
            this.naslov = naslov;
            this.opis = opis;
            InitializeComponent();
            nastavi();
        }

        public string Naslov
        {
            get
            {
                return this.naslov;
            }
            set
            {
                this.naslov = value;
            } 
        }
        public string Opis
        {
            get
            {
                return this.opis;
            }
            set
            {
                this.opis = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        private void nastavi()
        {
            this.naslov_label.Text = naslov;
            this.opis_textBox.Text = opis;
        }
    }
}
