using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace FormulaOneDLL {
    public class DBUtils {
        public const string WORKINGPATH = @"C:\data\formulaone\";
        public const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=" + WORKINGPATH + @"FormulaOne.mdf;Integrated Security=True";

        public DataTable GetData(string table) {
            DataTable retVal = new DataTable();
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            string sql = "SELECT * FROM " + table + ";";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(retVal);
            con.Close();
            da.Dispose();
            return retVal;
        }

        public Driver GetDriverByID(int code)
        {
            using (SqlConnection dbConn = new SqlConnection())
            {
                dbConn.ConnectionString = CONNECTION_STRING;
                dbConn.Open();
                string sql = "SELECT * FROM Driver WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, dbConn);
                cmd.Parameters.AddWithValue("@id", code);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    int number = reader.GetInt32(1);
                    string name = reader.GetString(2);
                    DateTime dob = reader.GetDateTime(3);
                    string pob = reader.GetString(4);
                    byte[] helmetImg = reader["helmetImg"] as byte[];
                    byte[] img = reader["img"] as byte[];
                    int teamId = reader.GetInt32(7);
                    int podiums = reader.GetInt32(8);
                    string countryCode = reader.GetString(9);
                    return new Driver(id, number, name, dob, pob, helmetImg, img, teamId, podiums, countryCode);
                }
            }
            return null;
        }

        public Team GetTeamByID(int code)
        {
            using (SqlConnection dbConn = new SqlConnection())
            {
                dbConn.ConnectionString = CONNECTION_STRING;
                dbConn.Open();
                string sql = "SELECT * FROM Team WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, dbConn);
                cmd.Parameters.AddWithValue("@id", code);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string teamName = reader.GetString(1);
                    byte[] teamLogo = reader["teamLogo"] as byte[];
                    string @base = reader.GetString(3);
                    string teamChief = reader.GetString(4);
                    string technicalChief = reader.GetString(5);
                    string powerUnit = reader.GetString(6);
                    byte[] carImage = reader["carImage"] as byte[];
                    string country = reader.GetString(8);
                    int worldChampionships = reader.GetInt32(9);
                    int polePositions = reader.GetInt32(10);
                    return new Team(id, teamName, teamLogo, @base, teamChief, technicalChief, powerUnit, carImage, country, worldChampionships, polePositions);
                }
            }
            return null;
        }

        public Country GetCountryByID(string code)
        {
            using (SqlConnection dbConn = new SqlConnection())
            {
                dbConn.ConnectionString = CONNECTION_STRING;
                dbConn.Open();
                string sql = "SELECT * FROM Country WHERE '" + code + "'=countryCode";
                SqlCommand cmd = new SqlCommand(sql, dbConn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string countryCode = reader.GetString(0);
                    string countryName = reader.GetString(1);
                    return new Country(countryCode, countryName);
                }
            }
            return null;
        }

        public List<Country> GetListCountry()
        {
            List<Country> retVal = new List<Country>();
            using (SqlConnection dbConn = new SqlConnection())
            {
                dbConn.ConnectionString = CONNECTION_STRING;
                dbConn.Open();
                string sql = "SELECT * FROM Country;";
                SqlCommand cmd = new SqlCommand(sql, dbConn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string countryCode = reader.GetString(0);
                    string countryName = reader.GetString(1);
                    Country c = new Country(countryCode, countryName);
                    retVal.Add(c);
                }
            }
            return retVal;
        }

        public List<Team> GetListTeam()
        {
            List<Team> retVal = new List<Team>();
            using (SqlConnection dbConn = new SqlConnection())
            {
                dbConn.ConnectionString = CONNECTION_STRING;
                dbConn.Open();
                string sql = "SELECT * FROM Team;";
                SqlCommand cmd = new SqlCommand(sql, dbConn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string teamName = reader.GetString(1);
                    byte[] teamLogo = reader["teamLogo"] as byte[];
                    string @base = reader.GetString(3);
                    string teamChief = reader.GetString(4);
                    string technicalChief = reader.GetString(5);
                    string powerUnit = reader.GetString(6);
                    byte[] carImage = reader["carImage"] as byte[];
                    string country = reader.GetString(8);
                    int worldChampionships = reader.GetInt32(9);
                    int polePositions = reader.GetInt32(10);
                    Team t = new Team(id, teamName, teamLogo, @base, teamChief, technicalChief, powerUnit, carImage, country, worldChampionships, polePositions);
                    retVal.Add(t);
                }
            }
            return retVal;
        }

        public List<Driver> GetListDriver()
        {
            List<Driver> retVal = new List<Driver>();
            using (SqlConnection dbConn = new SqlConnection())
            {
                dbConn.ConnectionString = CONNECTION_STRING;
                dbConn.Open();
                string sql = "SELECT * FROM Driver;";
                SqlCommand cmd = new SqlCommand(sql, dbConn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    int number = reader.GetInt32(1);
                    string name = reader.GetString(2);
                    DateTime dob = reader.GetDateTime(3);
                    string pob = reader.GetString(4);
                    byte[] helmetImg = reader["helmetImg"] as byte[];
                    byte[] img = reader["img"] as byte[];
                    int teamId = reader.GetInt32(7);
                    int podiums = reader.GetInt32(8);
                    string countryCode = reader.GetString(9);
                    Driver d = new Driver(id, number, name, dob, pob, helmetImg, img, teamId, podiums, countryCode);
                    retVal.Add(d);
                }
            }
            return retVal;
        }



        public static List<string> getTables() {
            DataTable retVal = new DataTable();
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            string sql = "SELECT * FROM INFORMATION_SCHEMA.TABLES";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(retVal);
            List<string> ts = new List<string>();
            ts.Add("--- Selezionare la tabella desiderata ---");
            foreach (DataRow item in retVal.Rows) {
                ts.Add((item["TABLE_NAME"].ToString()));
            }
            return ts;
        }

        public void ExecuteSqlScript(string sqlScriptName) {
            var fileContent = File.ReadAllText(WORKINGPATH + sqlScriptName);
            fileContent = fileContent.Replace("\r", "");
            fileContent = fileContent.Replace("\n", "");
            fileContent = fileContent.Replace("\t", "");
            var sqlqueries = fileContent.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            SqlConnection con = new SqlConnection(CONNECTION_STRING);

            using (con) {
                SqlCommand cmd = new SqlCommand("query", con);
                con.Open();
                int i = 0;
                int nErr = 0;
                foreach (var query in sqlqueries) {
                    cmd.CommandText = query;
                    i++;
                    try {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex) {
                        Console.WriteLine("Errore durante l'esecuzione della query " + i + "\n" + ex.Message);
                        nErr++;
                    }
                }
                if (nErr != 0) {
                    Console.WriteLine("Si sono verificati " + nErr + " errori");
                }
                else {
                    Console.Write("Esecuzione effettuata correttamente\n");
                }
            }
        }

        public void ResetDB() {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            using (con) {
                string[] nomeTabella = { "Driver", "Country", "Team", "Race", "Circuit", "Result" };
                con.Open();
                for (int i = 0; i < nomeTabella.Length; i++) {
                    SqlCommand cmd = new SqlCommand("DROP TABLE IF EXISTS " + nomeTabella[i] + ";", con);
                    try {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Tabella " + nomeTabella[i] + " eliminata correttamente");
                    }
                    catch (Exception ex) {
                        Console.WriteLine(ex.Message);
                    }
                }
                ExecuteSqlScript("Drivers.sql");
                ExecuteSqlScript("Countries.sql");
                ExecuteSqlScript("Teams.sql");
                ExecuteSqlScript("Races.sql");
                ExecuteSqlScript("Circuits.sql");
                ExecuteSqlScript("Results.sql");
            }
        }
    }
}
