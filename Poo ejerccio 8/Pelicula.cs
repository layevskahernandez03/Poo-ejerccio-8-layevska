using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_ejerccio_8
{
    class Pelicula
    {
        string Nom;
        int Año;       
        public Pelicula()
        {

        }
        public Pelicula(string nom, int año)
        {
            Nom = nom;
            Año = año;
        }

        public string Nom1 { get => Nom; set => Nom = value; }
        public int Año1 { get => Año; set => Año = value; }


    }
}
