
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Sales.UseCases.CreateOrder
{
    public class CreateOrderInteractor : ICreateOrderInputPort
    {
        readonly INorthWindSalesCommandsRepository Repository;
        readonly ICreateOrderOutputPort OutputPort;

        public CreateOrderInteractor(INorthWindSalesCommandsRepository repository, ICreateOrderOutputPort outputPort)
        {
            Repository = repository;
            OutputPort = outputPort;
        }

        public async ValueTask Handle(CreateOrderDTO orderDTO)
        {
            OrderAggregate Order = OrderAggregate.From(orderDTO);

            await Repository.CreateOrder(Order);
            await  Repository.SaveChanges();
            await OutputPort.Handle(Order.Id);
        }
    }
}
