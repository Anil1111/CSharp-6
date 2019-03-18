using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeuProjeto
{
    class FabricaDeConexao
    {




       
        private static string StringConexao = "Data Source=localhost;Initial Catalog=Base;User Id=sa;Pwd=sa;";


        public FabricaDeConexao()
        {
           
        }

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
