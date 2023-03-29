using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjSitematico2.Formularios
{
    public partial class frmSeleccion : Form
    {
        public frmSeleccion()
        {
            InitializeComponent();
        }

        private void pExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            frmSerializar frm = new frmSerializar();

            this.Close();

            this.Hide();

            frm.Show();
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            frmDeserializar frm1 = new frmDeserializar();

            this.Close();

            this.Hide();

            frm1.Show();
        }
    }
}
