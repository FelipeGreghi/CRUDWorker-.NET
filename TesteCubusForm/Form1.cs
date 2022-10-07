using System.Data.SqlClient;
using System.Windows.Input;
using TesteCubusForm.Data;
using TesteCubusForm.Entities;

namespace TesteCubusForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
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
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tsbCadastrar.Enabled = true;
            tsbListar.Enabled = true;
            tsbEditar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbBuscar.Enabled = true;
            tstBuscar.Enabled = true;
            txtNome.Enabled = false;
            txtSobrenome.Enabled = false;
            txtDataNascimento.Enabled = false;
            txtCpf.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand comand = new SqlCommand();
            Pessoa pessoa = new Pessoa(txtNome.Text, txtSobrenome.Text, txtDataNascimento.Text, txtCpf.Text);

            try
            {
                comand.Connection = Banco.abrir();
                comand.Connection.Open();
                comand.CommandText = "INSERT tbpessoa values ('" + pessoa.Nome + "','" + pessoa.Sobrenome + "','" + pessoa.DataNascimento + "','" + pessoa.Cpf + "')";
                comand.ExecuteNonQuery();
                MessageBox.Show("Pessoa inserida com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                comand.Connection.Close();
                tsbCadastrar.Enabled = true;
                tsbListar.Enabled = true;
                tsbEditar.Enabled = false;
                tsbExcluir.Enabled = false;
                tsbBuscar.Enabled = true;
                tstBuscar.Enabled = true;
                txtNome.Enabled = false;
                txtSobrenome.Enabled = false;
                txtDataNascimento.Enabled = false;
                txtCpf.Enabled = false;
                btnCadastrar.Enabled = false;
                txtNome.Clear();
                txtSobrenome.Clear();
                txtDataNascimento.Clear();
                tstBuscar.Clear();
                txtCpf.Clear();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tsbCadastrar.Enabled = true;
            tsbListar.Enabled = true;
            tsbEditar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbBuscar.Enabled = true;
            tstBuscar.Enabled = true;
            txtNome.Enabled = false;
            txtSobrenome.Enabled = false;
            txtDataNascimento.Enabled = false;
            txtCpf.Enabled = false;
            btnCadastrar.Enabled = false;
            txtNome.Clear();
            txtSobrenome.Clear();
            txtDataNascimento.Clear();
            tstBuscar.Clear();
            txtCpf.Clear();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SqlCommand comand = new SqlCommand();


            if (MessageBox.Show("Deseja realmente excluir este cadastro?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!");
            }
            else
            {
                
                try
                {
                    comand.Connection = Banco.abrir();
                    comand.Connection.Open();
                    comand.CommandText = "DELETE FROM tbpessoa WHERE pescodigo= '" + tstBuscar + "'";
                    comand.ExecuteNonQuery();
                    MessageBox.Show("Cadastro deletado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    comand.Connection.Close();
                    tsbCadastrar.Enabled = true;
                    tsbListar.Enabled = true;
                    tsbEditar.Enabled = false;
                    tsbExcluir.Enabled = false;
                    tsbBuscar.Enabled = true;
                    tstBuscar.Enabled = true;
                    txtNome.Enabled = false;
                    txtSobrenome.Enabled = false;
                    txtDataNascimento.Enabled = false;
                    txtCpf.Enabled = false;
                    btnCadastrar.Enabled = false;
                    txtNome.Clear();
                    txtSobrenome.Clear();
                    txtDataNascimento.Clear();
                    tstBuscar.Clear();
                    txtCpf.Clear();
                }
            }
            
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {

            SqlCommand comand = new SqlCommand();

            try
            {
                comand.Connection = Banco.abrir();
                comand.Connection.Open();
                comand.CommandText = "SELECT * FROM tbpessoa WHERE pescodigo= '"+ tstBuscar +"'";

                if (tstBuscar.Text == String.Empty)
                {
                    throw new Exception("Você precisa digitar um id!");
                }

                SqlDataReader dr = comand.ExecuteReader();
                dr.Read();

                if (dr.HasRows == false)
                {
                    throw new Exception("Id não cadastrado!");
                }

                txtNome.Text = Convert.ToString(dr["pesnome"]);
                txtSobrenome.Text = Convert.ToString(dr["pessobrenome"]);
                txtDataNascimento.Text = Convert.ToString(dr["pesdatnascimento"]);
                txtCpf.Text = Convert.ToString(dr["pescpf"]);
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                comand.Connection.Close();
                tsbCadastrar.Enabled = false;
                tsbListar.Enabled = false;
                tsbEditar.Enabled = true;
                tsbExcluir.Enabled = true;
                tsbBuscar.Enabled = true;
                tstBuscar.Enabled = true;
                txtNome.Enabled = true;
                txtSobrenome.Enabled = true;
                txtDataNascimento.Enabled = true;
                txtCpf.Enabled = true;
                btnCadastrar.Enabled = false;
                txtNome.Focus();
                tstBuscar.Clear();
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            SqlCommand comand = new SqlCommand();
            Pessoa pessoa = new Pessoa(txtNome.Text, txtSobrenome.Text, txtDataNascimento.Text, txtCpf.Text);

            try
            {
                comand.Connection = Banco.abrir();
                comand.Connection.Open();
                comand.CommandText = "UPDATE tbpessoa SET pesnome = '"+ pessoa.Nome +"', pessobrenome = '"+ pessoa.Sobrenome +"', pesdatnascimento = '"+ pessoa.DataNascimento +"', pescpf = '"+ pessoa.Cpf +"' WHERE pescodigo = '"+ tstBuscar +"'";
                comand.ExecuteNonQuery();
                MessageBox.Show("Cadastro atualizado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atualização não efetuada!" + ex.Message);
            }
            finally
            {
                comand.Connection.Close();
                tsbCadastrar.Enabled = true;
                tsbListar.Enabled = true;
                tsbEditar.Enabled = false;
                tsbExcluir.Enabled = false;
                tsbBuscar.Enabled = true;
                tstBuscar.Enabled = true;
                txtNome.Enabled = false;
                txtSobrenome.Enabled = false;
                txtDataNascimento.Enabled = false;
                txtCpf.Enabled = false;
                btnCadastrar.Enabled = false;
                txtNome.Clear();
                txtSobrenome.Clear();
                txtDataNascimento.Clear();
                tstBuscar.Clear();
                txtCpf.Clear();
            }
        }

        private void tsbCadastrar_Click(object sender, EventArgs e)
        {
            tsbCadastrar.Enabled = false;
            tsbListar.Enabled = false;
            tsbEditar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbBuscar.Enabled = false;
            tstBuscar.Enabled = false;
            txtNome.Enabled = true;
            txtSobrenome.Enabled = true;
            txtDataNascimento.Enabled = true;
            txtCpf.Enabled = true;
            btnCadastrar.Enabled = true;
            txtNome.Clear();
            txtSobrenome.Clear();
            txtDataNascimento.Clear();
            tstBuscar.Clear();
            txtCpf.Clear();

        }

        private void tsbListar_Click(object sender, EventArgs e)
        {
            Form2 list = new Form2();
            list.ShowDialog();
        }
    }
}