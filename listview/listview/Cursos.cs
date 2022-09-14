using System;
using System.Collections.Generic;
using System.Text;

namespace listview
{
    public class Cursos
    {
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        public double Costo { get; set; }
        public string Logo { get; set; }
        public override string ToString()
        {
            return Nombre;
        }

    }
}
