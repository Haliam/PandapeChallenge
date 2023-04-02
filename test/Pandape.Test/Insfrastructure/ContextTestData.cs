using System;
using System.Collections.Generic;
using System.Text;

namespace Pandape.Test.Insfrastructure
{
    public class ContextTestData
    {
       public static IEnumerable<object[]> ConnectionString =>
       new List<object[]>
       {
            new object[]
            {
                "Server=(localdb)\\mssqllocaldb;Database=PandapeDb;Trusted_Connection=True;MultipleActiveResultSets=true"
            }
       };
    }
}
