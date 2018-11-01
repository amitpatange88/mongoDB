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
            MDB.MongoDB mdb = new MDB.MongoDB();

            mdb.CreateCollectionOnMongo("clients");
            mdb.InsertInCollection("clients");
            Console.ReadKey();
        }
    }
}
