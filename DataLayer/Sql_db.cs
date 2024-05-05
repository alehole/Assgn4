using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace ControllerGUI.Data
{
    internal class Sql_db
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public void WriteDb(double value, string tagName)
        {
            string sqlQuery = "INSERT INTO LOG(Value, Timestamp, TagName) VALUES(@Value, CURRENT_TIMESTAMP, @TagName)";
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        // Add parameters with values to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Value", value);
                        cmd.Parameters.AddWithValue("@TagName", tagName);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
        public string ReadLastSample(string variableName)
        {
            string value = "Unknown";
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string sqlQuery1 = "SELECT top 1 Value, Timestamp,TagName  FROM LOG WHERE TagName = '";
                    string sqlQuery3 = "' ORDER BY [Timestamp] DESC";
                    string sqlQuery = sqlQuery1 + variableName + sqlQuery3;

                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    value = dr.GetValue(0).ToString();
                                    return value;
                                }

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred: {ex.Message}");
                    value = $"An error occurred: {ex.Message}";
                    return value;
                }
            }
            return value;
        }
        public (List<double>, List<string>) GetDataList(int numSamples, string TagName)
        {
            List<double> sensorDataList = new List<double>();
            List<string> dateTimeList = new List<string>();

            string? DataTimeStamp;
            double DataValue;

            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string sqlQuery1 = "SELECT top ";
                    string sqlQuery2 = numSamples.ToString();
                    string sqlQuery3 = " Value, Timestamp FROM LOG WHERE TagName = '";
                    string sqlQuery4 = TagName;
                    string sqlQuery5 = "' ORDER BY[Timestamp] DESC";
                    string sqlQuery = sqlQuery1 + sqlQuery2 + sqlQuery3+sqlQuery4+sqlQuery5;

                    using (var cmd = new SqlCommand(sqlQuery, con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr != null)
                            {
                                while (dr.Read())
                                {
                                    DataTimeStamp = dr["timestamp"].ToString();
                                    dateTimeList.Add(DataTimeStamp);
                                    DataValue = Convert.ToDouble(dr["Value"]);
                                    sensorDataList.Add(DataValue);
                                }
                                //return (sensorDataList, dateTimeList);
                            }
                        }
                    }
                    return (sensorDataList, dateTimeList);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"An error occurred: {ex.Message}");
                    return (null, null);
                }
            }
        }
    }
}
