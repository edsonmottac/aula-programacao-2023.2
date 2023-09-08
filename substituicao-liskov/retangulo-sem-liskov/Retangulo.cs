using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retangulo_sem_liskov
{
    internal class Retangulo
    {
        public virtual int Largura { get; set; }
        public virtual int Altura { get; set; }

        public virtual int Area()
        {
            return Largura * Altura;
        }
    }
}
