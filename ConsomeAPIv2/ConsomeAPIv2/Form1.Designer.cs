namespace ConsomeAPIv2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btGetData = new Button();
			dataGridView1 = new DataGridView();
			btCadastrar = new Button();
			btDeletar = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// btGetData
			// 
			btGetData.Location = new Point(54, 106);
			btGetData.Name = "btGetData";
			btGetData.Size = new Size(160, 53);
			btGetData.TabIndex = 0;
			btGetData.Text = "Recuperar Dados";
			btGetData.UseVisualStyleBackColor = true;
			btGetData.Click += btGetData_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(54, 179);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(744, 270);
			dataGridView1.TabIndex = 1;
			// 
			// btCadastrar
			// 
			btCadastrar.Location = new Point(54, 33);
			btCadastrar.Name = "btCadastrar";
			btCadastrar.Size = new Size(160, 51);
			btCadastrar.TabIndex = 2;
			btCadastrar.Text = "Cadastrar";
			btCadastrar.UseVisualStyleBackColor = true;
			btCadastrar.Click += btCadastrar_Click;
			// 
			// btDeletar
			// 
			btDeletar.Location = new Point(220, 33);
			btDeletar.Name = "btDeletar";
			btDeletar.Size = new Size(138, 51);
			btDeletar.TabIndex = 3;
			btDeletar.Text = "Deletar";
			btDeletar.UseVisualStyleBackColor = true;
			btDeletar.Click += btDeletar_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(926, 533);
			Controls.Add(btDeletar);
			Controls.Add(btCadastrar);
			Controls.Add(dataGridView1);
			Controls.Add(btGetData);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btGetData;
		private DataGridView dataGridView1;
		private Button btCadastrar;
		private Button btDeletar;
	}
}