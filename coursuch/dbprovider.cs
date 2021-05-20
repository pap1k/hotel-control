using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursuch
{
    class dbprovider
    {
        private SqlConnection sql;
        private string connectstring = @"Server = localhost; Database = hotel; Integrated Security = True; ";
        public dbprovider()
        {
            sql = new SqlConnection(connectstring);
            sql.Open();
        }
        public List<List<string>> SqlExec(string s)
        {
            SqlCommand cmd = new SqlCommand(s, sql);
            List<List<string>> result = new List<List<string>>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    bool flag = true;
                    int i = 0;
                    List<string> tmp = new List<string>();
                    while (flag)
                    {
                        try
                        {
                            tmp.Add(reader[i].ToString());
                            i++;
                        }
                        catch
                        {
                            flag = false;
                        }
                    }
                    result.Add(tmp);
                }
                if (result.Count() == 0)
                    return new List<List<string>>();
            }
            return result;
        }
    }
}
