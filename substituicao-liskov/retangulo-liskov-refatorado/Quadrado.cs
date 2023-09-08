using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retangulo_liskov_refatorado
{
    internal class Quadrado : IForma
    {
        public int Lado { get; set; }

        public int Area()
        {
            return Lado * Lado;
        }
    }
}
