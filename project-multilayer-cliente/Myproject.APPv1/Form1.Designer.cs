namespace Myproject.APPv1
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
            button1 = new Button();
            btExcluir = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            label1 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtTelefone = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            btPrevious = new Button();
            btNext = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(327, 213);
            button1.Name = "button1";
            button1.Size = new Size(129, 36);
            button1.TabIndex = 0;
            button1.Text = "Incluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(151, 213);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(81, 36);
            btExcluir.TabIndex = 1;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // button2
            // 
            button2.Location = new Point(240, 213);
            button2.Name = "button2";
            button2.Size = new Size(81, 36);
            button2.TabIndex = 2;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(602, 36);
            button3.Name = "button3";
            button3.Size = new Size(160, 26);
            button3.TabIndex = 3;
            button3.Text = "Carregar ListrBox";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(474, 68);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(288, 184);
            listBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 357);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(736, 150);
            dataGridView1.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(26, 313);
            button4.Name = "button4";
            button4.Size = new Size(146, 38);
            button4.TabIndex = 6;
            button4.Text = "Carregra DataGrid";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 50);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(26, 68);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(76, 30);
            txtID.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 50);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(120, 68);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(331, 30);
            txtNome.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 114);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(26, 132);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(155, 30);
            txtTelefone.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 114);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(196, 132);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(255, 30);
            txtEmail.TabIndex = 8;
            // 
            // label5
            // 
            label5.BackColor = Color.IndianRed;
            label5.Location = new Point(26, 291);
            label5.Name = "label5";
            label5.Size = new Size(744, 2);
            label5.TabIndex = 9;
            // 
            // btPrevious
            // 
            btPrevious.Location = new Point(379, 22);
            btPrevious.Name = "btPrevious";
            btPrevious.Size = new Size(34, 26);
            btPrevious.TabIndex = 10;
            btPrevious.Text = "<<";
            btPrevious.UseVisualStyleBackColor = true;
            btPrevious.Click += btPrevious_Click;
            // 
            // btNext
            // 
            btNext.Location = new Point(417, 22);
            btNext.Name = "btNext";
            btNext.Size = new Size(34, 26);
            btNext.TabIndex = 11;
            btNext.Text = ">>";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btNext_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Black;
            label6.Location = new Point(26, 191);
            label6.Name = "label6";
            label6.Size = new Size(420, 1);
            label6.TabIndex = 7;
            label6.Text = "Nome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 558);
            Controls.Add(btNext);
            Controls.Add(btPrevious);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtTelefone);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btExcluir);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btExcluir;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Button button4;
        private Label label1;
        private TextBox txtID;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtTelefone;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private Button btPrevious;
        private Button btNext;
        private Label label6;
    }
}