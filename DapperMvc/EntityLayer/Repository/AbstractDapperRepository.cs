using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Repository
{
    public abstract class AbstractDapperRepository : IDisposable
    {
        public readonly IDbConnection DbConnection;

        //Properties and Methods
        protected AbstractDapperRepository( )
        {
            //add System.ConfigurationManager
            DbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionName="].ConnectionString);
        }

        protected AbstractDapperRepository(string connectionName)
        {
            // web configden connection string değerini çeker
            DbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionName].ConnectionString);
        }

        public AbstractDapperRepository()
        {
            
        }


        public void Dispose()
        {

        }
    }

}
