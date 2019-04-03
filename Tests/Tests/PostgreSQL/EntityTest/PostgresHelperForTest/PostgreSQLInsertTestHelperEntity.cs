using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.PostgreSQL.EntityTest.PostgresHelperForTest
{
    public class PostgreSQLInsertTestHelperEntity
    {
        public void ExecuteSqlInsert<T>(string[] query) where T : DbContext, new()
        {
            using (var context = new T())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    foreach (string line in query)
                    {

                        if (line.Length > 0)
                        {
                            try
                            {
                                context.Database.ExecuteSqlCommand(line);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Exceptio :" + ex + "\n query : " + line);
                            }
                        }

                    }
                    context.SaveChanges();
                    transaction.Commit();
                }

            }
        }
    }
}
