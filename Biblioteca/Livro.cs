using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public double Isbn { get; set; }
        public int AnoPublicacao { get; set; }
        public string EstiloLiterario { get; set; }
        public int NumPaginas { get; set; }
        public string PaisPublicacao { get; set; }

        public Livro(double isbn, string titulo)
        {
            this.Isbn = isbn;
            this.Titulo = titulo;
        }
    }
}
