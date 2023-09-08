using inversao_dependencia4.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inversao_dependencia
{
    public class Conta : IConta
    {
        public void AtivarConta(IUsuario? usuario, string? login, string? senha)
        {
            Console.WriteLine($"\nUma nova conta foi criada para o usuáiro: {usuario.Nome}\n");
        }
    }
}
