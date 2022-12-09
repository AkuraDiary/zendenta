using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zendenta.SubPages.DaftarPasien
{
    public partial class ListPasienLayout : UserControl
    {
        public ListPasienLayout()
        {
            InitializeComponent();
        }

        public int idPasien { get; set; }
        public string namaPasien { get { return this.namaPasien; } set { this.lblPasienName.Text = value; } }
        public string emailPasien { get { return this.emailPasien; } set { this.lblPasienEmail.Text = value; } }
        public string telpPasien { get { return this.telpPasien; } set { this.lblPasienPhone.Text = value; } }
        public string cityPasien { get { return this.cityPasien; } set { this.lblPasienCity.Text = value; } }

        public DateTime lastAppoint { get { return this.lastAppoint; } set { this.lblPasienLastAp.Text = value.ToString("dd/MM/yyyy"); } }
        public DateTime nextAppoint { get { return this.nextAppoint; } set { this.lblPasienNextAp.Text = value.ToString("dd/MM/yyyy"); } }
    }
}
