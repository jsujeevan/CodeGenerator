using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassQSol_CodeGenerator_Console
{
    class Test
    {
        string vl_connectionString_s = "Server=localhost;Database=LondonDegree;Integrated Security=true";
        public List<string> getEmailCCList(int vl_serverId_i)
        {
            List<string> vl_emailList_o = new List<string>();
            using (SqlConnection vl_connection_s = new SqlConnection(vl_connectionString_s))
            {
                vl_connection_s.Open();
                SqlDataReader vl_reader_o = null;
                SqlCommand vl_command_o = new SqlCommand("sp_a_EmailOnFailureCCList_Get", vl_connection_s);
                vl_command_o.Parameters.Add(new SqlParameter("@in_server_i", vl_serverId_i));

                // Set the command object so it knows to execute a stored procedure
                vl_command_o.CommandType = CommandType.StoredProcedure;

                vl_reader_o = vl_command_o.ExecuteReader();



                while (vl_reader_o.Read())
                {

                    string vl_email_s = vl_reader_o["Email_s"].ToString();

                    vl_emailList_o.Add(vl_email_s);
                }
                vl_reader_o.Close();
                vl_connection_s.Close();
            }
            return vl_emailList_o;
        }

    }
}
