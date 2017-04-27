using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using hom.DataAccess.Factory;

namespace hom.DataAccess.DAL
{
    public class T_Stock_Main
    {
        public static bool Insert(hom.Entity.T_Stock_Main stockMain)
        {
            string sqlCommandText = @"INSERT INTO T_Stock_Main([Code]
                                     ,[Name]
                                     ,[Price]
                                     ,[Market]
                                     ,[Plate]
                                     ,[Status]
                                     ,[MaxPrice]
                                     ,[MinPrice]
                                     ,[HistoryRecordDate]
                                     ,[LocationPercent]
                                     ,[CreateTime]
                                     ,[UpdateTime])VALUES(
                                     @Code
                                    ,@Name
                                    ,@Price
                                    ,@Market
                                    ,@Plate
                                    ,@Status
                                    ,@MaxPrice
                                    ,@MinPrice
                                    ,@HistoryRecordDate
                                    ,@LocationPercent
                                    ,@CreateTime
                                    ,@UpdateTime
                                    )";
            using (IDbConnection conn = ConnectionManager.GetConnection(ConnectionFactory.StockDB))
            {
                //User user = new User();
                //user.UserName = "Dapper";
                //user.Password = "654321";
                //user.Email = "Dapper@infosys.com";
                //user.PhoneNumber = "13795666243";
               int result = conn.Execute(sqlCommandText, stockMain);
                return result > 0;
               
            }
        }

    }
}
