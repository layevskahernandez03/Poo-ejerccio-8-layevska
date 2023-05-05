using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_ejerccio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula pe = new Pelicula("Titanic",1998);
            Actor ac = new Actor("Axel", "Cano");
            ac.Actuar();
            Estudio es = new Estudio("sony", "Layevksa");
            es.Produce();
        }
    }
}
