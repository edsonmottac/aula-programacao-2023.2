using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retangulo_sem_liskov
{
    internal class Quadrado : Retangulo
    {
        // Assumindo que um quadrado tem lados iguais, poderíamos
        // apenas igualar a largura e a altura para calcular a área (será?)
        public override int Largura
        {
            get { return base.Largura; }
            set { base.Largura = value; base.Altura = value; }
        }

        public override int Altura
        {
            get { return base.Altura; }
            set { base.Altura = value; base.Largura = value; }
        }
    }
}
