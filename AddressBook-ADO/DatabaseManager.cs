using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AddressBook_ADO
{
    class DatabaseManager
    {
        //UC1
        public void CreateDatabase()
        {
            //Sql Connection
            SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDb)\localdb;Integrated Security=True");

            //Sql Query to Create Databse
            String str = "CREATE DATABASE AddressBook ";

            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                Console.WriteLine("DataBase is Created Successfully");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
    }
}
