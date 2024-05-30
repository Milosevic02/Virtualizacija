using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public class Order
    {
        private int id;
        private string path;
        private bool delivered;
        public Order(int id, string path)
        {
            this.id = id;
            this.path = path;
            this.delivered = false;
        }

        public Order() { }

        [DataMember]
        public int Id { get { return id;} set { id = value; } }
        [DataMember]
        public string Path { get { return path; } set { path = value; }  }
        [DataMember]
        public bool Delivered { get { return delivered; } set { delivered = value; } }

        

    }
}
