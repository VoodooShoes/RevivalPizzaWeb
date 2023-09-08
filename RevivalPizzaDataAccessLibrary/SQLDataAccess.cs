//using System.ComponentModel;
//using System.Data;

//namespace RevivalPizzaDataAccessLibrary
//{
//    public class SQLDataAccess
//    {
//        public List<T> LoadData<T , U> (string sqlStatement, U parameters, string connectionString)
//        {
//            using (IDbConnection connection = new SqlConnection(connectionString))
//            {
//                List<T> rows = connection.Query<T> (sqlStatement, parameters).ToList();
//                return rows;
//            }
//        }

//        public void SaveData<T>(string sqlStatement, T parameters, string connectionString)
//        {
//            using (IDbConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Equals(sqlStatement, parameters)
//            }

//        }
//    }
//}