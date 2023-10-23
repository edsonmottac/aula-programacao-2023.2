using Microsoft.EntityFrameworkCore;
using MyProject.DAL.DBContext;
using MyProject.MODEL;

namespace MyProject.BLL
{
    public static class LivroRepository
    {

        public static void Add(Livro _livro)
        {
            using (var DbContext = new DBibliotecarevisaoMyprojectDalDatabaseDatabase1MdfContext()) {
                DbContext.Add(_livro);
                DbContext.SaveChanges();
            }
        }
    
        public static Livro GetById(int id)
        {
            using (var DbContext = new DBibliotecarevisaoMyprojectDalDatabaseDatabase1MdfContext())
            {
                
                var livro = DbContext.Livros.Single(p => p.Id == id);
                return livro;

            }

        }

        public static List<Livro> getAll()
        {

            return null;
        }
    
    }
}