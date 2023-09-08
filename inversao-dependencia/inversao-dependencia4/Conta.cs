using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inversao_dependencia
{
    public class Conta
    {
        public void AtivarConta(Usuario usuario, string login, string senha)
        {
            Console.WriteLine($"\nUma nova conta foi criada para o usuáiro: {usuario.Nome}\n");
        }
    }
}
