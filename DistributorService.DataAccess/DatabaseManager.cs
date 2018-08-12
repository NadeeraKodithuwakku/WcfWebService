using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOrderData
{
    public class DatabaseManager : IDatabaseManager
    {
        public List<WorkOrderDetails> Read()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["OrderDBConnection"].ConnectionString))
            {
                string readSp = "GetAllOrders";
                return db.Query<WorkOrderDetails>(readSp, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void AddWorkDetails(WorkOrderDetails workOrderDetails)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["OrderDBConnection"].ConnectionString))
            {
                var formParams = new DynamicParameters();
                formParams.Add("@distributorNumber", workOrderDetails.DistributorNumber);
                formParams.Add("@workOrderNumber", workOrderDetails.WorkOrderNumber);
                var result = db.Execute("AddWorkOrderDetails", formParams, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
