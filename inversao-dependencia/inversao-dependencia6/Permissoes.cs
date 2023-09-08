using inversao_dependencia4.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inversao_dependencia
{
    public class Permissoes : IPermissoes
    {
        public void CriaPermissoes(IUsuario usuario, string permissao)
        {
            Console.WriteLine($"Foi atribuida a permissão de {permissao} ao usuário {usuario.Nome}");
        }

    }
}



