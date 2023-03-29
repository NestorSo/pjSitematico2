using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesDeSerializarSerializar;
namespace pjSitematico2.Formularios
{
    public partial class frmDeserializar : Form
    {
        public frmDeserializar()
        {
            InitializeComponent();
        }
        List<RegistroDeLibros> listaRegistros = new List<RegistroDeLibros>();


        RegistroDeLibros registro = null;
       
        string fileName = "Registro De Libros.json";
        string jsonString = string.Empty;
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmSeleccion frm = new frmSeleccion();

            this.Close();

            this.Hide();

            frm.Show();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorArchivo = new OpenFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();

            if (resultado == DialogResult.Cancel)
                return;
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Iniciamos la Deserializacón de los datos ", "Registrando",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


            //Deserilizamos 
            jsonString = File.ReadAllText(fileName);

            listaRegistros = JsonSerializer.Deserialize<List<RegistroDeLibros>>(jsonString)!;


            //usamos el objeto 
            foreach (var list in listaRegistros)
            {
                int data = Deserializar.Rows.Add();
                Deserializar.Rows[data].Cells[0].Value = list.ISBN1.ToString();
                Deserializar.Rows[data].Cells[1].Value = list.Autor1.ToString();
                Deserializar.Rows[data].Cells[2].Value = list.Editorial1.ToString();
                Deserializar.Rows[data].Cells[3].Value = list.Titulo1.ToString();
                Deserializar.Rows[data].Cells[4].Value = list.NumeroDePaginas1.ToString();

            }
        }
    }
}
