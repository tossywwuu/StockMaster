using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hom.DataAccess.Factory
{
    public class ConnectionManager
    {
      

        private static Dictionary<ConnectionFactory, string> connections=new Dictionary<ConnectionFactory, string>();


        public static SqlConnection GetConnection(ConnectionFactory factory)
        {
            if (!connections.ContainsKey(factory))
            {
                string connstr = System.Configuration.ConfigurationManager.ConnectionStrings[factory.ToString()].ToString();
               
                connections.Add(factory, connstr);
               
            }
            SqlConnection connection =new  SqlConnection(connections[factory]);
            connection.Open();
            return connection;
        }
      
       
    }
    public enum ConnectionFactory
    {
        StockDB
    }
}
