using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests.OracleDbServeTests.EntityTests.OracleHelperForTest
{
    public class OracleInsertTestHelperEntity
    {
        public void ExecuteSqlInsert<T>(string[] query) where T : DbContext, new()
        {
            int lineStoppped = 100;
            int count = 0;
            using (var context = new T())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    foreach (string line in query)
                    {

                        if (count < lineStoppped)
                        {
                            try
                            {
                                context.Database.ExecuteSqlCommand(line);
                                count++;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Exceptio :" + ex + "\n query : " + line);
                            }
                        }
                        else
                        {
                            break;
                        }

                    }
                    context.SaveChanges();
                    transaction.Commit();
                }

            }
        }
    }
}
