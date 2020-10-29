using System;
using System.Data.SqlClient;
using System.IO;

using FormulaOneDLL;

namespace FormulaOneConsole
{
    class Program
    {
        public const string WORKINGPATH = @"C:\data\formulaone\";
        private const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=" + WORKINGPATH + @"FormulaOne.mdf;Integrated Security=True";

        public static DBUtils dbUtils = new DBUtils();
        static void Main(string[] args)
        {
            Console.WriteLine("*** FORMULA ONE - BATCH OPERATIONS");
            char scelta = ' ';
            do
            {
                Console.WriteLine("1 - Create Countries");
                Console.WriteLine("2 - Create Teams");
                Console.WriteLine("3 - Create Drivers");
                Console.WriteLine("4 - Create Relationships");
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
                            dbUtils.ExecuteSqlScript("Countries.sql");
                            break;
                        }
                    case '2':
                        {
                            dbUtils.ExecuteSqlScript("Teams.sql");
                            break;
                        }
                    case '3':
                        {
                            dbUtils.ExecuteSqlScript("Drivers.sql");
                            break;
                        }
                    case '4':
                        {
                            dbUtils.ExecuteSqlScript("Relationships.sql");
                            break;
                        }
                    case 'R':
                        {
                            dbUtils.ResetDB();
                            break;
                        }
                }
            } while (scelta != 'X' && scelta != 'x');
        }
    }
}
