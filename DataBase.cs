using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class DataBase
    {

        MySqlConnection connetion = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=proger");

        public void openconetion() //соединение 

        {
            if (connetion.State == System.Data.ConnectionState.Closed)
                connetion.Open();
        }
        public void closeconetion()

        {
            if (connetion.State == System.Data.ConnectionState.Open)
                connetion.Close();
        }

        public MySqlConnection getconetion()
        { 
            return connetion;
        }
    }
}
