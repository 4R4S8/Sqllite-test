using System.Data.SQLite;

namespace TestSQLlite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new SQLite database file
            //SQLiteConnection.CreateFile("MyDatabase.sqlite");

            // Create a connection to the database
            using (var conn = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;"))
            {
                // Open the connection
                conn.Open();

                // Create a command to execute SQL statements
                using (var cmd = new SQLiteCommand(conn))
                {
                    //Create a table named Employee
                    //cmd.CommandText = "CREATE TABLE Employee (Id INTEGER PRIMARY KEY, Name TEXT, Job TEXT)";
                    //cmd.ExecuteNonQuery();

                    // Insert some data into the table

                    //cmd.CommandText = "CREATE TABLE services (id INTEGER PRIMARY KEY,name TEXT NOT NULL, price REAL NOT NULL, duration INTEGER NOT NULL)";
                    //cmd.ExecuteNonQuery();
                    //cmd.CommandText = "CREATE TABLE customers (id INTEGER PRIMARY KEY,  name TEXT NOT NULL,  phone TEXT NOT NULL,  email TEXT,  address TEXT NOT NULL)";
                    //cmd.ExecuteNonQuery();
                    //cmd.CommandText = "CREATE TABLE jobs(id INTEGER PRIMARY KEY, customer_id INTEGER NOT NULL,service_id INTEGER NOT NULL,quantity INTEGER NOT NULL,status TEXT NOT NULL, pickup_date TEXT NOT NULL,delivery_date TEXT NOT NULL, FOREIGN KEY (customer_id) REFERENCES customers(id), FOREIGN KEY (service_id) REFERENCES services(id))";
                    //cmd.ExecuteNonQuery();



                    // Query the data from the table
                    cmd.CommandText = "SELECT Id FROM Employee where Name = 'Alice'";
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Loop through the results and print them to the console
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}")/*, Name: {reader["Name"]}, Job: {reader["Job"]}")*/;
                        }
                    }
                }

                // Close the connection
                conn.Close();
            }
        }
    }
}
