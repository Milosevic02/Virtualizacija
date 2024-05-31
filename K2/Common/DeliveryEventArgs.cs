using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class DeliveryEventArgs:EventArgs
    {
        private int id;
        private int fee;

        public DeliveryEventArgs(int id, int fee)
        {
            this.id = id;
            this.fee = fee;
        }

        public int Id { get { return id; } set { id = value; } }
        public int Tips { get { return fee; } set { fee = value; } }
    }
}
