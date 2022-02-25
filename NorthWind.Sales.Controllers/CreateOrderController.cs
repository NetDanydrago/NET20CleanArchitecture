using NorthWind.Sales.BusinessObjects.DTOs.CreateOrder;
using NorthWind.Sales.BusinessObjects.Interfaces.Controllers;
using NorthWind.Sales.BusinessObjects.Interfaces.Ports;
using NorthWind.Sales.BusinessObjects.Interfaces.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Sales.Controllers
{
    public class CreateOrderController : ICreateOrderController
    {
        readonly ICreateOrderInputPort CreateOrderInputPort;
        readonly ICreateOrderPresenter CreateOrderPresenter;

        public CreateOrderController(ICreateOrderInputPort createOrderInputPort, ICreateOrderPresenter createOrderPresenter)
        {
            CreateOrderInputPort = createOrderInputPort;
            CreateOrderPresenter = createOrderPresenter;
        }

        public async ValueTask<int> CreateOrder(CreateOrderDTO createOrderDTO)
        {
            await CreateOrderInputPort.Handle(createOrderDTO);
            return CreateOrderPresenter.OrderId;
        }
    }
}
