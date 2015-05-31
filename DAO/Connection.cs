﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace DAO
{ 
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name="master")]
    public class Connection
    {
        private SqlConnection conn;

        //connect to sql server
        public Connection()
        {
            conn = new SqlConnection("Data Source=HP;Initial Catalog=SQL_QUANLYHOCSINH;Integrated Security=True");
        }

        //open connect
        private SqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        //exec
        public bool ExecQuery(string query)
        {
            openConnection();
            try
            {

                SqlCommand cm = new SqlCommand(query, conn);
                cm.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
