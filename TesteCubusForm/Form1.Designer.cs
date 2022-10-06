namespace TesteCubusForm
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
            this.nome = new System.Windows.Forms.Label();
            this.sobrenome = new System.Windows.Forms.Label();
            this.dataNascimento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cpf = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(12, 24);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(57, 20);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome :";
            this.nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // sobrenome
            // 
            this.sobrenome.AutoSize = true;
            this.sobrenome.Location = new System.Drawing.Point(12, 87);
            this.sobrenome.Name = "sobrenome";
            this.sobrenome.Size = new System.Drawing.Size(93, 20);
            this.sobrenome.TabIndex = 1;
            this.sobrenome.Text = "Sobrenome :";
            // 
            // dataNascimento
            // 
            this.dataNascimento.AutoSize = true;
            this.dataNascimento.Location = new System.Drawing.Point(12, 151);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(149, 20);
            this.dataNascimento.TabIndex = 2;
            this.dataNascimento.Text = "Data de nascimento :";
            this.dataNascimento.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(204, 27);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(12, 110);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(204, 27);
            this.txtSobrenome.TabIndex = 4;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(12, 174);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(204, 27);
            this.txtDataNascimento.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(127, 289);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(89, 29);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 29);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(12, 218);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(44, 20);
            this.cpf.TabIndex = 9;
            this.cpf.Text = "CPF : ";
            this.cpf.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(12, 241);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(204, 27);
            this.txtCpf.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 330);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.sobrenome);
            this.Controls.Add(this.nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nome;
        private Label sobrenome;
        private Label dataNascimento;
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private TextBox txtDataNascimento;
        private Button btnCadastrar;
        private Button btnCancelar;
        private Label label1;
        private TextBox textBox1;
        private Label cpf;
        private TextBox txtCpf;
    }
}