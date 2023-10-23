// See https://aka.ms/new-console-template for more information
using MyProject.BLL;
using MyProject.MODEL;



Livro livro= new Livro();
livro = LivroRepository.GetById(1);
Console.WriteLine("Titulo:" + livro.Titulo);
