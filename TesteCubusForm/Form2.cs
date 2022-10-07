using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using TesteCubusForm.Data;
using TesteCubusForm.Entities;

namespace TesteCubusForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            SqlCommand comand = new SqlCommand();
            List<Pessoa> pessoaList = new List<Pessoa>();
            
            comand.Connection = Banco.abrir();
            comand.Connection.Open();
            comand.CommandText = "SELECT * FROM tbpessoa";
            SqlDataReader dr = comand.ExecuteReader();
            
            while (dr.Read())
            {
                Pessoa pessoa = new Pessoa(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetDateTime(3).ToString(), dr.GetString(4));
                pessoaList.Add(pessoa);
            }


            dataGridView1.DataSource = pessoaList;
            dr.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
