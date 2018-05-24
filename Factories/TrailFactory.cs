using System.Collections.Generic;
using System.Data;
using Lost_in_the_Woods.Models;
using MySql.Data.MySqlClient;
using Dapper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;

namespace Lost_in_the_Woods.Factory
{
    public class TrailFactory : IFactory<Trail>
    {
        private string connectionString;
        public TrailFactory()
        {
            connectionString = "server=localhost;userid=root;password=root;port=3306;database=Lost_in_the_Woods;SslMode=None";
        }
        internal IDbConnection Connection
        {
            get {
                return new MySqlConnection(connectionString);
            }
        }
        public List<Trail> GetAllTrails()
        {
            using(IDbConnection dbConnection = Connection)
            {
                using(IDbCommand command = dbConnection.CreateCommand())
                {
                   string query = "SELECT * FROM trails";
                   dbConnection.Open();
                   return dbConnection.Query<Trail>(query).ToList();
                   
                }
            }
        }
        public Trail FindTrail(int id)
        {
            using(IDbConnection dbConnection = Connection)
            {
                using(IDbCommand command = dbConnection.CreateCommand())
                {
                   dbConnection.Open();
                   return dbConnection.Query<Trail>("SELECT * FROM trails WHERE Id = @Id", new {ID = id}).FirstOrDefault();
                }
            }
        }
        public void AddNewTrail(Trail trail)
        {
            using (IDbConnection dbConnection = Connection)
            {
                using(IDbCommand command = dbConnection.CreateCommand())
                {
                    string query = @"INSERT INTO trails (Name, Description, Length, Elevation, Longitude, Latitude, CreatedAt, UpdatedAt) 
                    VALUES (@Name, @Description, @Length, @Elevation, @Longitude, @Latitude, NOW(), NOW())";
                    dbConnection.Open();
                    dbConnection.Execute(query, trail);
                }
            }
        }
    }
}