
using inversao_dependencia;

public class Program
{
    public static void Main(string[] args)
    {
        
        Usuario usuario = new Usuario { Nome = "Jose", Login = "jse", Senha = "1234"};    
       
        Conta conta = new Conta();
        conta.AtivarConta(usuario, usuario.Login, usuario.Senha);

        Permissoes permissoes = new Permissoes();
        permissoes.CriaPermissoes(usuario, "Administrador");

        Console.ReadLine(); 
    }
}





