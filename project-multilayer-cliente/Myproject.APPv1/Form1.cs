using Microsoft.VisualBasic;
using MyProject.BLL;
using MyProject.MODEL;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Myproject.APPv1
{
    public partial class Form1 : Form
    {
        private List<Cliente> lista_clientes;
        private int position = 0;
        public Form1()
        {
            InitializeComponent();
            lista_clientes = new List<Cliente>();
            laodData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Cliente c = new Cliente();
                c.Nome = txtNome.Text;
                c.Telefone = txtTelefone.Text;
                c.Email = txtEmail.Text;
                ClienteRepository.Add(c);
                MessageBox.Show("Registro Gravado com Sucesso!", "MyProject", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Falha ao gravar o registro!", "MyProject", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Id = int.Parse(txtID.Text);
            ClienteRepository.Excluir(c);
            MessageBox.Show("Registro Dleetado");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Id = int.Parse(txtID.Text); ;
            c.Nome = txtNome.Text;
            c.Telefone = txtTelefone.Text;
            c.Email = txtEmail.Text;

            ClienteRepository.Update(c);
            MessageBox.Show("Registro Editado");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Cliente> list = ClienteRepository.GetAll();
            //listBox1.Items.Add(list);

            listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "Nome";
            listBox1.DataSource = list.Select(c => new { IdNome = $"{c.Id} - {c.Nome}" }).ToList(); ;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Cliente> list = ClienteRepository.GetAll();
            dataGridView1.DataSource = list;
        }

       
        private void laodData()
        {
            lista_clientes = ClienteRepository.GetAll().ToList();

            var Cliente = lista_clientes[position];
            txtID.Text = Cliente.Id.ToString();
            txtNome.Text = Cliente.Nome;
            txtEmail.Text = Cliente.Email;
            txtTelefone.Text = Cliente.Telefone;
        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            position--;
            if (position < lista_clientes.Count - 1) position = 0;
                laodData();
            

            


        }

        private void btNext_Click(object sender, EventArgs e)
        {
            position++;
            if (position > lista_clientes.Count - 1) position = 0;
            laodData();
        }
    }
};