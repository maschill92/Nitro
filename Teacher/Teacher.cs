﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Teacher
{
    public class Teacher
    {
        public String username;
        private String password;
        public String fName;
        public String lName;
        public Teacher(String uName)
        {
            String str = "select * from teacher as t where t.username = '" + uName + "'";
            MySqlDataReader rdr = MySQL_Manager.MySqlManager.Instance.ExecuteReader(str);
            if (rdr == null)
            {
                throw new Exception("ERROR: THE AUTHENTICATED TEACHER DOESN'T EXIST!");
            }
            rdr.Read();
            this.username = rdr["username"].ToString();
            this.password = rdr["password"].ToString();
            this.fName = rdr["fName"].ToString();
            this.lName = rdr["lName"].ToString();
        }

        public bool Update(String pWord, String fName, String lName)
        {
            String str = "update teacher set password='" + pWord + "', fName='" + fName + "', lName='"
                + lName + "' where username='" + this.username + "';";
            bool ret = MySQL_Manager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }
    }
}
