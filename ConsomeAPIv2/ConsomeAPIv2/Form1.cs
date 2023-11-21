using ConsomeAPIv2.Model;
using Newtonsoft.Json;

namespace ConsomeAPIv2
{
	public partial class Form1 : Form
	{

		HttpClient httpClient = new HttpClient();


		public Form1()
		{
			InitializeComponent();
		}

		private async void btGetData_Click(object sender, EventArgs e)
		{
			string url = "http://localhost:5195/api/Cliente";


			HttpResponseMessage resposta = await httpClient.GetAsync(url);

			var content = await resposta.Content.ReadAsStringAsync();

			List<Cliente> clientes = JsonConvert.DeserializeObject<List<Cliente>>(content);

			dataGridView1.DataSource = clientes;

		}

		private async void btCadastrar_Click(object sender, EventArgs e)
		{
			Cliente cliente = new Cliente();
			cliente.Nome = "Fulano de Tal";
			cliente.Telefone = "4565678";
			cliente.Email = "fulano@gmail.com";

			string c = JsonConvert.SerializeObject(cliente);
			var conteudo = new StringContent(c, System.Text.Encoding.UTF8, "application/json");
			var response = await httpClient.PostAsync("http://localhost:5195/api/Cliente", conteudo);

			var retorno = await response.Content.ReadAsStringAsync();

			MessageBox.Show("Registro Adiconado com Sucesso\n" + retorno);

		}

		private async void btDeletar_Click(object sender, EventArgs e)
		{

			var response = await httpClient.DeleteAsync("http://localhost:5195/api/Cliente?id=27");
			var retorno = await response.Content.ReadAsStringAsync();

			MessageBox.Show("Registro deletado com sucesso!\n\n" + retorno);
		}
	}
}