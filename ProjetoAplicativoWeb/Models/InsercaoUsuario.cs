using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAplicativoWeb.Models {
    public class InsercaoUsuario {

        public static void InsereUsuario(string nome, string email) {

            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.Conectar();
            command.CommandText = $"INSERT Usuarios values('{nome}','{email}')";
            command.ExecuteNonQuery();

        }

    }
}
