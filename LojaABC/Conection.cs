using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace LojaABC
{
    public class Conection
    {
        private static string conexao = "server=localhost;port=3306;database=dbTransforme;uid=root;pwd=''";
        private static MySqlConnection conn = null;

        public static MySqlConnection obterconexao()
        {
            conn = new MySqlConnection(conexao);
            try
            {
                conn.Open();
            }
            catch (MySqlException)
            {
                conn = null;
            }
            return conn;
        }
        public static void fecharconexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
