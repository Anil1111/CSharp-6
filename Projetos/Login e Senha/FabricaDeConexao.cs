using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class FabricaDeConexao
    {

        private static string StringConexao = "Data Source=LocalHost;Initial Catalog=DataBase;User Id=sa;Pwd=sa;";
        

        public static SqlConnection CriarConexao()
        {

            SqlConnection FabricaConexao = new SqlConnection(StringConexao);
            FabricaConexao.Open();
            return FabricaConexao;


        }

        public bool testeConexao()
        {
                SqlConnection testeConexao = new SqlConnection(StringConexao);
                testeConexao.Open();
                return true;
        }




    }
}
