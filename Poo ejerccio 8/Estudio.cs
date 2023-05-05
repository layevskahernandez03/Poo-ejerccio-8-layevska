using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_ejerccio_8
{
    class Estudio
    {
        string Nom;
        string Direcion;
        public string Produce()
        {
            return ToString();
        }
 

        public Estudio()
        {

        }

        public Estudio(string nom, string direcion)
        {
            Nom = nom;
            Direcion = direcion;
        }

        public string Nom2 { get => Nom; set => Nom = value; }
        public string Direcion1 { get => Direcion; set => Direcion = value; }
    }
}
