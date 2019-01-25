using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
	
	/*
	factory Connection
	Sintaxe
	SqlConnection sqlconn = factoryConect.Create();
	Create the connection Without need to use sqlconn.Open();	
	*/
	
	
    class factoryConnectiont
    {

        private static string StringConexao = "Data Source=LocalHost;Initial Catalog=DataBase;User Id=sa;Pwd=sa;";
       

        public static SqlConnection Create()
        {

            SqlConnection factoryConect = new SqlConnection(StringConnect);
            factoryConect.Open();
            return factoryConect;


        }

    




    }
}
