﻿using ConnectionToSQL.PD_Layer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionToSQL.Helper;

namespace ConnectionToSQL.DA_Layer
{
    public static class UsersDA
    {
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static Users RetrieveUser(string username)
        {
            string query = "SELECT * FROM signintutorial.users where userName = (@username) limit 1";
            cmd = DBHelper.RunQuery(query, username);
            Users aUser = null;
            if(cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    string uName = dr["username"].ToString();
                    string password = dr["password"].ToString();
                    aUser = new Users(uName, password);
                }
            }
            return aUser;
        }
    }
}
