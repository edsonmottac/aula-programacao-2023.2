using inversao_dependencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inversao_dependencia4.factory
{
    public static class Factory
    {
        public static Usuario GetUsuario()
        {
            return new Usuario();
        }

        public static Conta GetConta()
        {
            return new Conta();
        }
        public static Permissoes GetPermisses()
        {
            return new Permissoes();
        }

    }
}
