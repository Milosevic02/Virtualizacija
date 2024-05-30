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
        private int tips;

        public DeliveryEventArgs(int id, int tips)
        {
            this.id = id;
            this.tips = tips;
        }

        public int Id { get { return id; } set { id = value; } }
        public int Tips { get { return tips; } set { tips = value; } }
    }
}
