using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using Dapper;
using HelloWorld.Models;
using Microsoft.Data.SqlClient;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;";


            IDbConnection dbConnection = new SqlConnection(connectionString);

            string sglCommand = "SELECT GETDATE()";
            DateTime rightNow = dbConnection.QuerySingle<DateTime>(sglCommand);
            Console.WriteLine(rightNow);

            // Computer myComputer = new Computer() 
            // {
            //     Motherboard = "Z690",
            //     HasWifi = true,
            //     HasLTE = false,
            //     ReleaseDate = DateTime.Now,
            //     Price = 943.87m,
            //     VideoCard = "RTX 2060"
            // };

            // Console.WriteLine(myComputer.Price);
        }
    }
}
