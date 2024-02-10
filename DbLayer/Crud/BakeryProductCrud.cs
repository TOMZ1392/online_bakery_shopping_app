using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBakeryShopper.DbLayer
{
    public class BakeryProductCrud
    {
        public string ConnectionString { get; set; }
        public BakeryProductCrud(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
