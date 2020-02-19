using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary
{
    public class DataBase
    {
        protected SqlConnection Cn;
        protected SqlCommand Cmd;
        protected SqlDataReader rdr;
        protected string ConStr = @"Data Source=MOHAMMAD_YASFO;Initial Catalog=EWARS;Integrated Security=True";
        public DataBase()
        {
            Cn = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Connection = Cn;

        }
    }
}
