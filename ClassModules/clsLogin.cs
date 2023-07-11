using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLine.ClassModules
{
    internal class clsLogin
    {
        public void conectar()
        {
            String sql = "select * from loggin";
            CConexion con = new CConexion();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con.establecerConexion());

        }
    }
}
