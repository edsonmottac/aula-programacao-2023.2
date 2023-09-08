
using inversao_dependencia5;
using inversao_dependencia5.interfaces;

public class Program
{
    public static void Main(string[] args)
    {

        IUsuario usuario = new Usuario { Nome = "Jose", Login = "jse", Senha = "1234" };

        IConta conta = new Conta();
        conta.AtivarConta(usuario, "jse", "1234");

        IPermissoes permissoes = new Permissoes();
        permissoes.CriaPermissoes(usuario, "Administrador");

        Console.ReadLine();
    }
}



