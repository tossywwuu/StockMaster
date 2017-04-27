using hom.DataAccess.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hom.DataAccess.Factory;
using System.Data.SqlClient;

namespace hom.DataAccess.Tests
{
    [TestClass]
    public class ConnStringManagerTest
    {
        [TestMethod]
        public void Connections()
        {
           SqlConnection t= ConnectionManager.GetConnection(ConnectionFactory.StockDB);
        }
    }
}
