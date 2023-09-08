using inversao_dependencia4.@interface;

namespace inversao_dependencia4.@interface
{
    public interface IPermissoes
    {
        void CriaPermissoes(IUsuario usuario, string permissao);
    }
}