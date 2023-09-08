using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inversao_dependencia
{
    public class Usuario
    {
        private string? nome;
        private string? login;
        private string? senha;

        public string? Nome { get => nome; set => nome = value; }
        public string? Login { get => login; set => login = value; }
        public string? Senha { get => senha; set => senha = value; }
    }
}






