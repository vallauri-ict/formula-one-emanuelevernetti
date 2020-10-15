using System;
using System.Data.SqlClient;
using System.IO;

namespace FormulaOneConsole
{
    class Program
    {
        public const string WORKINGPATH = @"C:\data\formulaone\";
        private const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=" + WORKINGPATH + @"FormulaOne.mdf;Integrated Security=True";
        static void Main(string[] args)
        {
            Console.WriteLine("*** FORMULA ONE - BATCH OPERATIONS");
            char scelta = ' ';
            do
            {
                Console.WriteLine("1 - Create Countries");
                Console.WriteLine("2 - Create Teams");
                Console.WriteLine("3 - Create Drivers");
                Console.WriteLine("---------------");
                Console.WriteLine("R - RESET DB");
                Console.WriteLine("---------------");
                Console.WriteLine("X - ESCI");
                Console.Write("\nScelta desiderata: ");
                scelta = Convert.ToChar(Console.ReadLine());
                switch (scelta)
                {
                    case '1':
                        {
                            ExecuteSqlScript("Countries.sql");
                            break;
                        }
                    case '2':
                        {
                            ExecuteSqlScript("Teams.sql");
                            break;
                        }
                    case '3':
                        {
                            ExecuteSqlScript("Drivers.sql");
                            break;
                        }
                    case 'R':
                        {
                            ResetDB();
                            break;
                        }
                }
            } while (scelta != 'X' && scelta != 'x');
        }

        private static void ResetDB()
        {
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            using (con)
            {
                string[] nomeTabella = { "Driver", "Country", "Team" };
                con.Open();
                for (int i = 0; i < nomeTabella.Length; i++)
                {
                    SqlCommand cmd = new SqlCommand("DROP TABLE IF EXISTS " + nomeTabella[i]+";", con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Tabella " + nomeTabella[i] + " eliminata correttamente");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                ExecuteSqlScript("Countries.sql");
                ExecuteSqlScript("Teams.sql");
                ExecuteSqlScript("Drivers.sql");
            }
        }

        private static void ExecuteSqlScript(string sqlScriptName)
        {
            var fileContent = File.ReadAllText(WORKINGPATH + sqlScriptName);
            fileContent = fileContent.Replace("\r", "");
            fileContent = fileContent.Replace("\n", "");
            fileContent = fileContent.Replace("\t", "");
            var sqlqueries = fileContent.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            SqlConnection con = new SqlConnection(CONNECTION_STRING);

            using (con)
            {
                SqlCommand cmd = new SqlCommand("query", con);
                con.Open();
                int i = 0;
                int nErr = 0;
                foreach (var query in sqlqueries)
                {
                    cmd.CommandText = query;
                    i++;
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Errore durante l'esecuzione della query " + i + "\n" + ex.Message);
                        nErr++;
                    }
                }
                if (nErr != 0)
                {
                    Console.WriteLine("Si sono verificati " + nErr + " errori");
                }
                else
                {
                    Console.Write("\nEsecuzione effettuata correttamente\n\n");
                }
            }
        }
    }
}
