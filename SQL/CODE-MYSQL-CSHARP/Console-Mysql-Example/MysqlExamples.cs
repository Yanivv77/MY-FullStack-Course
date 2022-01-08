using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Mysql.examples
{
    /// <summary>
    /// based on https://zetcode.com/csharp/mysql/
    /// </summary>
    public static class MysqlExamples
    {
        const string connectionString = @"server=localhost;userid=root;password=admin;database=mydb";
        public static void CheckMySqlDBVersionStep1()
        {
            using var con = new MySqlConnection(connectionString);
            con.Open();

            // We check for the version of the MySQL database. This time using an SQL query.
            var stm = "SELECT VERSION()";

            // The MySqlCommand is an object which is used to execute a query on the database. The parameters are the SQL statement and the connection object.
            var cmd = new MySqlCommand(stm, con);

            var version = cmd.ExecuteScalar().ToString();
            Console.WriteLine($"MySQL version: {version}");
        }

        public static void MySQLCreateTableStep2()
        {
            using var con = new MySqlConnection(connectionString);
            con.Open();

            using var cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "DROP TABLE IF EXISTS cars";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE cars(id INTEGER PRIMARY KEY AUTO_INCREMENT,
            name TEXT, price INT)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Audi',52642)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Mercedes',57127)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Skoda',9000)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Volvo',29000)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Bentley',350000)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Citroen',21000)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Hummer',41400)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Volkswagen',21600)";
            cmd.ExecuteNonQuery();

            Console.WriteLine("Table cars created");
        }

        public static void MySqlInsertNewCarStep3(string carName, int price)
        {
            using var con = new MySqlConnection(connectionString);
            con.Open();
            var sql = "INSERT INTO cars(name, price) VALUES(@name, @price)";
            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@name", carName);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            Console.WriteLine("row inserted");
        }

        public static void MySqlReadDataStep4()
        {
            var con = new MySqlConnection(connectionString);
            con.Open();

            string sql = "SELECT * FROM cars";
            using var cmd = new MySqlCommand(sql, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0} {1} {2}", rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2));
            }
        }

        public static void MySqlRunStoredProcuder(string firstName, string lastName)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("insert_student", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("p_firstname", firstName));
                command.Parameters.Add(new MySqlParameter("p_lastname", lastName));
                command.Connection.Open();
                var result = command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

    }
}
