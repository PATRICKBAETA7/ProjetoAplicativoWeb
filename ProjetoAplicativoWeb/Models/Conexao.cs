using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoAplicativoWeb.Models {
    public class Conexao {

        public static SqlConnection Conectar() {

            string conexao = @"Data Source=DESKTOP-9G4P5JV\SQLEXPRESS;Initial Catalog=ProjetoAplicativoWeb;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();
            return connection;
        }



    }
}
