using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeSerializarSerializar
{
    [Serializable]
    public class RegistroDeLibros
    {
            private string ISBN;
            private string Titulo;
            private string Autor;
            private string Editorial;
            private int NumeroDePaginas;

            public RegistroDeLibros() : this("", "", "","", 0)
            {

            }

        public RegistroDeLibros(string iSBN, string titulo, string autor, string editorial, int numeroDePaginas)
        {
            ISBN1 = iSBN;
            Titulo1 = titulo;
            Autor1 = autor;
            Editorial1 = editorial;
            NumeroDePaginas1 = numeroDePaginas;
        }

        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public string Titulo1 { get => Titulo; set => Titulo = value; }
        public string Autor1 { get => Autor; set => Autor = value; }
        public string Editorial1 { get => Editorial; set => Editorial = value; }
        public int NumeroDePaginas1 { get => NumeroDePaginas; set => NumeroDePaginas = value; }

       

        }
    
}
