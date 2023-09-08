using inversao_dependencia4.@interface;

namespace inversao_dependencia4.@interface
{
    public interface IConta
    {
        void AtivarConta(IUsuario? usuario, string? login, string? senha);
    }
}