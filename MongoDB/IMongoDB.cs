using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    public interface IMongoDB
    {
        void InsertInCollection(string collectionName);

        void CreateCollection(string collectionName);

        void DropCollection(string collectionName);
    }
}
