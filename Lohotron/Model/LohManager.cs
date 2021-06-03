using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Lohotron.Model
{
    public class LohManager : ILohManager
    {
        private string connectionString = null;

        public LohManager(string conn)
        {
            connectionString = conn;
        }

        public void Create(LOH loh)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO LOH(fullname, inn, telephone, vaccinationpoint) " +
                    "VALUES (@fullname , @inn, @telephone, @vaccinationpoint )";
                db.Execute(sqlQuery, loh);
            }
        }

        public List<LOH> Get()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<LOH>("SELECT * FROM LOH").ToList();
            }
        }
    }
}
