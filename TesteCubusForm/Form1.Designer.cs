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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFuncionarios = new System.Windows.Forms.TabPage();
            this.tabPessoas = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCadastrar = new System.Windows.Forms.ToolStripButton();
            this.tsbListar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlBuscar = new System.Windows.Forms.ToolStripLabel();
            this.tstBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tabTurnos = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPessoas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(6, 37);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(46, 15);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome :";
            this.nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // sobrenome
            // 
            this.sobrenome.AutoSize = true;
            this.sobrenome.Location = new System.Drawing.Point(6, 84);
            this.sobrenome.Name = "sobrenome";
            this.sobrenome.Size = new System.Drawing.Size(74, 15);
            this.sobrenome.TabIndex = 1;
            this.sobrenome.Text = "Sobrenome :";
            // 
            // dataNascimento
            // 
            this.dataNascimento.AutoSize = true;
            this.dataNascimento.Location = new System.Drawing.Point(6, 132);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(118, 15);
            this.dataNascimento.TabIndex = 2;
            this.dataNascimento.Text = "Data de nascimento :";
            this.dataNascimento.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 54);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(179, 23);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(6, 101);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(179, 23);
            this.txtSobrenome.TabIndex = 4;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(6, 149);
            this.txtDataNascimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(179, 23);
            this.txtDataNascimento.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(107, 236);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(78, 22);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(6, 236);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 22);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(6, 183);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(37, 15);
            this.cpf.TabIndex = 9;
            this.cpf.Text = "CPF : ";
            this.cpf.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(6, 200);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(179, 23);
            this.txtCpf.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFuncionarios);
            this.tabControl1.Controls.Add(this.tabPessoas);
            this.tabControl1.Controls.Add(this.tabTurnos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 295);
            this.tabControl1.TabIndex = 11;
            // 
            // tabFuncionarios
            // 
            this.tabFuncionarios.Location = new System.Drawing.Point(4, 24);
            this.tabFuncionarios.Name = "tabFuncionarios";
            this.tabFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabFuncionarios.Size = new System.Drawing.Size(466, 267);
            this.tabFuncionarios.TabIndex = 0;
            this.tabFuncionarios.Text = "Funcionários";
            this.tabFuncionarios.UseVisualStyleBackColor = true;
            // 
            // tabPessoas
            // 
            this.tabPessoas.Controls.Add(this.pictureBox1);
            this.tabPessoas.Controls.Add(this.toolStrip1);
            this.tabPessoas.Controls.Add(this.nome);
            this.tabPessoas.Controls.Add(this.txtCpf);
            this.tabPessoas.Controls.Add(this.txtNome);
            this.tabPessoas.Controls.Add(this.btnCancelar);
            this.tabPessoas.Controls.Add(this.sobrenome);
            this.tabPessoas.Controls.Add(this.btnCadastrar);
            this.tabPessoas.Controls.Add(this.txtDataNascimento);
            this.tabPessoas.Controls.Add(this.dataNascimento);
            this.tabPessoas.Controls.Add(this.cpf);
            this.tabPessoas.Controls.Add(this.txtSobrenome);
            this.tabPessoas.Location = new System.Drawing.Point(4, 24);
            this.tabPessoas.Name = "tabPessoas";
            this.tabPessoas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPessoas.Size = new System.Drawing.Size(466, 267);
            this.tabPessoas.TabIndex = 1;
            this.tabPessoas.Text = "Pessoas";
            this.tabPessoas.UseVisualStyleBackColor = true;
            this.tabPessoas.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCadastrar,
            this.tsbListar,
            this.tsbEditar,
            this.tsbExcluir,
            this.toolStripSeparator1,
            this.tlBuscar,
            this.tstBuscar,
            this.tsbBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(460, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCadastrar
            // 
            this.tsbCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCadastrar.Image")));
            this.tsbCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadastrar.Name = "tsbCadastrar";
            this.tsbCadastrar.Size = new System.Drawing.Size(23, 22);
            this.tsbCadastrar.Text = "Cadastrar";
            this.tsbCadastrar.Click += new System.EventHandler(this.tsbCadastrar_Click);
            // 
            // tsbListar
            // 
            this.tsbListar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbListar.Image = ((System.Drawing.Image)(resources.GetObject("tsbListar.Image")));
            this.tsbListar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbListar.Name = "tsbListar";
            this.tsbListar.Size = new System.Drawing.Size(23, 22);
            this.tsbListar.Text = "Listar";
            this.tsbListar.Click += new System.EventHandler(this.tsbListar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(23, 22);
            this.tsbExcluir.Text = "Excluir";
            this.tsbExcluir.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tlBuscar
            // 
            this.tlBuscar.Name = "tlBuscar";
            this.tlBuscar.Size = new System.Drawing.Size(82, 22);
            this.tlBuscar.Text = "Buscar por Id :";
            // 
            // tstBuscar
            // 
            this.tstBuscar.Name = "tstBuscar";
            this.tstBuscar.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(23, 22);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // tabTurnos
            // 
            this.tabTurnos.Location = new System.Drawing.Point(4, 24);
            this.tabTurnos.Name = "tabTurnos";
            this.tabTurnos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTurnos.Size = new System.Drawing.Size(466, 267);
            this.tabTurnos.TabIndex = 2;
            this.tabTurnos.Text = "Turnos";
            this.tabTurnos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 295);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPessoas.ResumeLayout(false);
            this.tabPessoas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

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
        private TabControl tabControl1;
        private TabPage tabFuncionarios;
        private TabPage tabPessoas;
        private TabPage tabTurnos;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbCadastrar;
        private ToolStripButton tsbListar;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel tlBuscar;
        private ToolStripTextBox tstBuscar;
        private ToolStripButton tsbBuscar;
        private PictureBox pictureBox1;
    }
}