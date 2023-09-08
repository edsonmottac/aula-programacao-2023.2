
using inversao_dependencia;
using inversao_dependencia4.factory;
using inversao_dependencia4.@interface;

public class Program
{
    public static void Main(string[] args)
    {
        
        IUsuario usuario = Factory.GetUsuario();
        usuario.Nome = "Jose";
        usuario.Login = "jse";
        usuario.Senha = "1234";    
       
        IConta conta =  Factory.GetConta();
        conta.AtivarConta(usuario, usuario.Login, usuario.Senha);

        IPermissoes permissoes = Factory.GetPermisses();
        permissoes.CriaPermissoes(usuario, "Administrador");

        Console.ReadLine(); 
    }
}





