using MyProject.BLL;
using MyProject.MODEL;

namespace MyProject.APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            livro.Titulo = txtTitulo.Text;
            livro.Editora = txtEditora.Text;
            livro.Resumo = "Bla bla bla";
            livro.Ano = "2023";

            LivroRepository.Add(livro);

            MessageBox.Show("Registro gravado com sucesso!");
        }

        private void btRecuperaID_Click(object sender, EventArgs e)
        {

            Livro livro;

            int id = int.Parse(txtId.Text);
            livro = LivroRepository.GetById(id);

            txtTitulo.Text = livro.Titulo;
            txtEditora.Text = livro.Editora;

            MessageBox.Show("Livro recuperado com êxito", "Consulta", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Livro> l = LivroRepository.getAll();
        }
    }
}