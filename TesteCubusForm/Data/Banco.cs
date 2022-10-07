using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TesteCubusForm.Data
{
    public static class Banco
    {
        public static SqlConnection abrir()
        {

            //string strConn = "server=127.0.0.1;userid=root;database=enfermagemdb";//RegEx

            
            string strConn = @"Server=192.168.0.254 ;Database=treinamento;User Id=treinamento;Password=@Treina@#Cubus;";
            SqlConnection cn = new SqlConnection(strConn);
            return cn;
        }
    }
}
