using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retangulo_liskov_refatorado
{
    internal class Retangulo : IForma
    {
        public int Largura { get; set; }
        public int Altura { get; set; }

        public int Area()
        {
            return Largura * Altura;
        }
    }
}
