using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Database
    {
        readonly static Dictionary<string, Order> collectionOfOrders;

        static Database()
        {
            collectionOfOrders = new Dictionary<string, Order>();

        }

        public static Dictionary<string, Order> CollectionOfOrders { get { return collectionOfOrders; } }
    }
}
