using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPDemo
{
    public class OrderProcessor
    {
        private IDatabase _database;

        public OrderProcessor(IDatabase database)
        {
            _database = database;
        }
        public void Process() 
        {
            _database.Save();
        }
    }
}
