using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace JDRApplication.data
{

  

    public class DataAccess
    {
        private string connectionString = "mongodb+srv://Sahtra:Sland999@cluster0.hkjjw.mongodb.net/test";
        private DataAccess Instance;

        public DataAccess GetInstance()
        {
            if (Instance == null)
                return new DataAccess();
            else
                return Instance;
        }

        private DataAccess()
        {
            MongoClient dbClient = new MongoClient(connectionString);

            var dbList = dbClient.ListDatabases().ToList();

            Console.WriteLine("The list of databases on this server is: ");
            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }
        }

    }
}
