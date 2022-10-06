using System.Data.SqlClient;
using TesteCubusForm.Data;

namespace TesteCubusForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        } 

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand comand = new SqlCommand();
            comand.Connection = Banco.abrir();
            comand.Connection.Open();
            comand.CommandText = "INSERT tbpessoa values ('" + txtNome.Text + "','" + txtSobrenome.Text + "','"+ txtDataNascimento.Text +"','"+ txtCpf.Text +"')";
            comand.ExecuteNonQuery();
            comand.Connection.Close();
            MessageBox.Show("Pessoa inserida com sucesso!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}