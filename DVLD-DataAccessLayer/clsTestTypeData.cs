using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsTestTypeData
    {
        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM TestTypes order by TestTypeID";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return dt;

        }
    }
}
