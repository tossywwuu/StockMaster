using hom.DataAccess.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hom.DataAccess.Tests.DAL
{
    [TestClass]
    public class T_Stock_Main_Test
    {

        [TestMethod]
        public void TestInsert()
        {
            hom.Entity.T_Stock_Main stock = new Entity.T_Stock_Main();
            stock.Code = "000000";
            stock.Name = "上海测试";
            stock.Price = 5;
            stock.CreateTime = DateTime.Now;
            T_Stock_Main.Insert( stock);
        }

        
    }
}
