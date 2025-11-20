using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPDemo
{
    internal class SqlDatabase : IDatabase
    {
        public void Save()
        {
            Console.WriteLine("Saving to SQL");
        }
    }
}
