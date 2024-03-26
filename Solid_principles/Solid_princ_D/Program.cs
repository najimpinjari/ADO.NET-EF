using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_princ_D
{
    interface IDataAccess
    {
        void LoadData();
    }

    // Class for data access using SQL
    class SqlDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading data from SQL database...");
        }
    }

    // Class for data access using MongoDB
    class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading data from MongoDB...");

            Console.ReadLine();
        }
    }

    // High-level module
    class DataManager
    {
        private readonly IDataAccess _dataAccess;

        public DataManager(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void LoadData()
        {
            _dataAccess.LoadData();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDataAccess sqlDataAccess = new SqlDataAccess();
            IDataAccess mongoDataAccess = new MongoDataAccess();

            DataManager sqlDataManager = new DataManager(sqlDataAccess);
            DataManager mongoDataManager = new DataManager(mongoDataAccess);

            sqlDataManager.LoadData();   // Output: Loading data from SQL database...
            mongoDataManager.LoadData(); // Output: Loading data from MongoDB...
        }
    }
}
