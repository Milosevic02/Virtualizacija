using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public class OrderDetails:IDisposable
    {
        [DataMember]
        public MemoryStream MemoryStream {  get; set; }

        [DataMember]
        public string FileName { get; set; }

        public void Dispose()
        {
            if(MemoryStream == null)
            {
                return;
            }
            try
            {
                MemoryStream.Dispose();
                MemoryStream.Close();
                MemoryStream = null;
            }catch(Exception)
            {
                Console.WriteLine("Unsuccessful disposing");
            }
        }
    }
}
