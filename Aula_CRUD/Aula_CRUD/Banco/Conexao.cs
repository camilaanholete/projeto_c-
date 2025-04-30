using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_CRUD.Banco
{
    public class Conexao
    {
        public static MySqlConnection getConexao()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306;" +
                    "database=aula_c_noite2; username=root; password='';");
                return con;
            }catch (Exception ex) {
                return null;

                
            }
        }

    }
}
