using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    class Database
    {
        private SqlDataReader rdr;
        private const string localDB = "F17ST2ITS2201607091";

        private SqlConnection Openconn()
        {
            var conn = new SqlConnection(@"Data Source=i4dab.ase.au.dk;Initial Catalog=" + localDB + ";Persist Security Info=True;User ID=" + localDB + ";Password=" + localDB + "");

            conn.Open();

            return conn;
        }

        public HP_DTO verifyLoginInformation(HP_DTO HealthProfessional)
        {

            using (SqlCommand cmd = new SqlCommand("select * from Health_professional where EmployeeID = @EmployeeID" + "AND Password = @Password", Openconn()))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", HealthProfessional.EmployeeID);
                cmd.Parameters.AddWithValue("@Password", HealthProfessional.Password);
                using (rdr = cmd.ExecuteReader())
                {
                    
                }
            }

        }
    }
}
