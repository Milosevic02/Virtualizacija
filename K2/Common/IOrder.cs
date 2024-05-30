using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IOrder
    {
        [OperationContract]
        void SendOrderRequest(OrderDetails orderDetails);

        [OperationContract]
        List<Order>GetAllOrders();

        [OperationContract]
        [FaultContract(typeof(CustomException))]
        void ProcessDelivery(string orderId, int fee);

        [OperationContract]
        void Subscribe();

        [OperationContract]
        void Unsubscribe();
    }
}
