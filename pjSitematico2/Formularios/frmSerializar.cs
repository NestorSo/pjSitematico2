using Microsoft.Win32;
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
using System.Security.AccessControl;

namespace pjSitematico2.Formularios
{
    public partial class frmSerializar : Form
    {
        public frmSerializar()
        {
            InitializeComponent();
        }

        List<RegistroDeLibros> listaRegistros = new List<RegistroDeLibros>();
        private FileStream salida; // mantiene la conexión con el archivo
        
        RegistroDeLibros registro = null;
        int isbn;
        string valorIsbn = "";
        string titulo = "";
        string autor = "";
        string editorial = "";
        int numeroDePaginas ;
        string valorNumeroDePaginas  = "";
        string fileName = "Registro De Libros.json";
        string jsonString = string.Empty;
        RegistroDeLibros registrar = new RegistroDeLibros("","","","",0);  
        

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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.')  && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && ! char.IsPunctuation(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {


            //Empezamos la serialización
            MessageBox.Show("Iniciamos la serializacón de los datos ", "Registrando",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            jsonString = JsonSerializer.Serialize(listaRegistros);
            File.WriteAllText(fileName, jsonString);
        }

        public void LimpiarCajasDeTexto()
        {

            txtCodigo.Clear();
            txtAutor.Clear();
            txtTitulo.Clear();
            txtEditorial.Clear();
            txtPaginas.Clear();

            txtCodigo.Focus();
            txtPaginas.Focus();
        }

        private void btnAñadirRegistro_Click(object sender, EventArgs e)
        {


            if (Valida()=="")
            {
                //Guardamos el isbn del libro
                valorIsbn = txtCodigo.Text;

                //while (!int.TryParse(valorIsbn, out isbn))
                //{
                //    MessageBox.Show("El valor de entrada es incorrecto, introduzca un valor entero", "Error de registro",
                //         MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    valorIsbn = txtCodigo.Text;
                //}

                //guardamos el titulo del libro

                titulo = txtTitulo.Text;

                //leemos el nombre del autor 
                autor = txtAutor.Text;

                //guardamos la editorial del libro 
                editorial = txtEditorial.Text;

                //guardamos el valor del numero de paginas 
                numeroDePaginas = int.Parse(txtPaginas.Text);

                //while (!decimal.TryParse(valorNumeroDePaginas, out numeroDePaginas))
                //{
                //    MessageBox.Show("El valor de entrada es incorrecto, introduzca un valor entero", "Error de registro",
                //          MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    valorNumeroDePaginas = txtPaginas.Text;
                //}

                registro = new RegistroDeLibros(valorIsbn, titulo, autor, editorial, numeroDePaginas);
                listaRegistros.Add(registro);
                LimpiarCajasDeTexto();
            }
            else
            {

                MessageBox.Show("Debe ingresar valores en los campos, el error esta en: "+Valida(), "Hay un campo vacio",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

               
            }

           
        }

        private void txtPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.') )
            {
                e.Handled = true;
            }
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private string Valida()
        {
            if (txtCodigo.Text.Trim().Length == 0)
            {
                txtCodigo.Focus();
                return "ISBN del libro";
            }
            else if (txtAutor.Text.Trim().Length == 0)
            {
                txtAutor.Focus();
                return "Autor del libro";
            }
            else if (txtEditorial.Text.Trim().Length == 0)
            {
                txtEditorial.Focus();
                return "Editorial del libro";
            }
            else if (txtTitulo.Text.Trim().Length == 0)
            {
                txtTitulo.Focus();
                return "Titulo del libro";
            }
            else if (txtPaginas.Text.Trim().Length == 0)
            {
                txtPaginas.Focus();
                return "Cantidad de paginas del libro";
            }
            return "";
        }

    }
}
