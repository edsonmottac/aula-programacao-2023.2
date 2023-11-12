using Microsoft.EntityFrameworkCore;
using MyProject.MODEL;
using MyProject.DAL.DBContext;

namespace MyProject.BLL
{
    public static class ClienteRepository
    {
        public static Cliente Add(Cliente _cliente)
        {

            using (var dbContext = new DProjectMultilayerMyprojectDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(_cliente);
                dbContext.SaveChanges();
            }
            return _cliente;
        }

        public static Cliente GetById(int Id)
        {

            using (var dbContext = new DProjectMultilayerMyprojectDalDatabaseDatabaseMdfContext())
            {
                try
                {
                    var cliente = dbContext.Clientes.Single(p => p.Id == Id);
                    return cliente;
                } catch
                {
                    return null;

                }
            }
        }

        public static List<Cliente> GetAll()
        {

            using (var dbContext = new DProjectMultilayerMyprojectDalDatabaseDatabaseMdfContext())
            {
                var cliente = dbContext.Clientes.ToList();
                return cliente;

            }
        }

        public static void Excluir(Cliente _cliente)
        {
            using (var dbContext = new DProjectMultilayerMyprojectDalDatabaseDatabaseMdfContext())
            {
                var cliente = dbContext.Clientes.Single(p => p.Id == _cliente.Id);
                dbContext.Remove(cliente);
                dbContext.SaveChanges();
            }
        }

        public static void Update(Cliente _cliente)
        {
            using (var dbContext = new DProjectMultilayerMyprojectDalDatabaseDatabaseMdfContext())
            {
                var cliente = dbContext.Clientes.Single(p => p.Id == _cliente.Id);
                cliente.Nome = _cliente.Nome;
                cliente.Email = _cliente.Email;
                cliente.Telefone = _cliente.Telefone;
                dbContext.SaveChanges();
            }
        }

        public static List<Cliente> QuerySQL()
        {
            using (var dbContext = new DProjectMultilayerMyprojectDalDatabaseDatabaseMdfContext())
            {
                var query = dbContext.Clientes.FromSqlRaw("SELECT * FROM Cliente");
                List<Cliente> clientes = query.ToList<Cliente>();
                return clientes;
            }

        }
    
        public static String GetCidadeCliente(Cliente _cliente)
        {
            String ddd = _cliente.Telefone.Substring(1, 2);

            Dictionary<int, String> dicionario = new Dictionary<int, String>();
            dicionario.Add(71, "Salvador");
            dicionario.Add(21, "São Paulo");
            dicionario.Add(11, "Rio de Janeiro");
            return dicionario[int.Parse(ddd)];

        }
    
    }
}