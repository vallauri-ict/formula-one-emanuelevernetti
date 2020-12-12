using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace FormulaOneDLL {
    public class DBUtils {
        public const string WORKINGPATH = @"C:\data\formulaone\";
        private const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=" + WORKINGPATH + @"FormulaOne.mdf;Integrated Security=True";

        public List<string> GetCountries() {
            List<string> retVal = new List<string>();
            using (SqlConnection con = new SqlConnection()) {
                con.ConnectionString = CONNECTION_STRING;
                string sql = "SELECT * FROM Country";
                using (SqlCommand command = new SqlCommand(sql, con)) {
                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            string Isocode = reader.GetString(0);
                            string country = reader.GetString(1);
                            retVal.Add(Isocode + "-" + country);
                        }
                    }
                }
            }
            return retVal;
        }

        public object GetDrivers() {
            List<string> retVal = new List<string>();
            using (SqlConnection con = new SqlConnection()) {
                con.ConnectionString = CONNECTION_STRING;
                string sql = "SELECT * FROM Driver ORDER BY id ASC";
                using (SqlCommand command = new SqlCommand(sql, con)) {
                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(2);
                            retVal.Add(id + "-" + name);
                        }
                    }
                }
            }
            return retVal;
        }

        public object GetTeams() {
            List<string> retVal = new List<string>();
            using (SqlConnection con = new SqlConnection()) {
                con.ConnectionString = CONNECTION_STRING;
                string sql = "SELECT * FROM Team";
                using (SqlCommand command = new SqlCommand(sql, con)) {
                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            int id = reader.GetInt32(0);
                            string teamName = reader.GetString(1);
                            retVal.Add(id + "-" + teamName);
                        }
                    }
                }
            }
            return retVal;
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
