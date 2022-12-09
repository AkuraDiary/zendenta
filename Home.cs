using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zendenta.model;
using zendenta.SubPages.Pembayaran;
using zendenta.SubPages.DaftarPasien;
using zendenta.SubPages.Overview;

namespace zendenta
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        #region formSetting

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion

        private void Home_Load(object sender, EventArgs e)
        {
            
            fillBindDataPasien();
            fillDataTreatment();
        }

        #region fills method
        void fillBindDataPasien()
        {
            Patient.fillList();
            lblSumPasien.Text = Patient.dummyListPatien.Count.ToString();
            foreach(var dataPasien in Patient.dummyListPatien)
            {
                ListPasienLayout pasienLayoutList = new ListPasienLayout();
                pasienListContainer.Controls.Add(pasienLayoutList);
            }
        }

        void fillDataTreatment()
        {
            for (int i = 0; i < 20; i++)
            {
                TreatmentLayout listItemTreatment = new TreatmentLayout();
                flowPanelRecentTreatmen.Controls.Add(listItemTreatment);
            }
        }

        #endregion

    }
}
