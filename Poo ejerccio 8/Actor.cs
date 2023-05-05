using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_ejerccio_8
{
    class Actor
    {
        string Nom;
        string Ape;

        public string Actuar()
        {
            return ToString();
        }
        public Actor(string nom, string ape)
        {
            Nom = nom;
            Ape = ape;
        }
        public string Nom1 { get => Nom; set => Nom = value; }
        public string Ape1 { get => Ape; set => Ape = value; }
    }
}
