
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Sales.Presenters
{
    public class CreateOrderPresenter : ICreateOrderPresenter
    {
        public int OrderId  {get; private set;}

        public ValueTask Handle(int orderId)
        {
           OrderId = orderId;
           return ValueTask.CompletedTask;
        }
    }
}
