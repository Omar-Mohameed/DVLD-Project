using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsCountryData
    {
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Countries order by CountryName";

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
                LogError("General Exception: " + ex.Message);
            }
            return dt;
        }

        public static bool GetCountryByName(ref int id, string name)
        {
            bool isFound = false;
            string query = "SELECT * FROM Countries WHERE CountryName = @CountryName"; // parametarize query
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CountryName", name);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                id = (int)reader["CountryID"];
                            }
                            else
                            {
                                isFound=false;
                            }
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
            return isFound;
        }

        public static bool GetCountryInfoByID(int countryID, ref string countryName)
        {
            bool isFound = false;
            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";
            try
            {
                using(SqlConnection connection = new SqlConnection(ConnectionSettings.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryID", countryID);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                countryName = (string)reader["CountryName"];
                            }
                            else
                            {
                                isFound=false;
                            }
                        }
                    }
                }

            }
            catch
            {
                isFound = false;
            }
            return isFound;
        }

        private static void LogError(string message)
        {
            // تسجيل الخطأ (قد يكون ملفًا نصيًا أو نظام تسجيل أخطاء)
            Console.WriteLine(message); // استبدل بـ نظام تسجيل أخطاء فعلي.
        }
    }
}
