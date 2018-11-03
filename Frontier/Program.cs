using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDB = MongoDB;

namespace Frontier
{
    class Program
    {
        static void Main(string[] args)
        {
            MDB.IMongoDB mdb = new MDB.MongoDB();
            
            mdb.CreateCollection("clients");
            mdb.InsertInCollection("clients");
            Console.ReadKey();
        }
    }
}
