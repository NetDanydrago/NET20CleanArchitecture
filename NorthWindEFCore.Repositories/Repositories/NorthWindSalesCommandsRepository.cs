
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindEFCore.Repositories.Repositories
{
    public class NorthWindSalesCommandsRepository : INorthWindSalesCommandsRepository
    {
        readonly NorthWindSalesContext Context;

        public NorthWindSalesCommandsRepository(NorthWindSalesContext context)
        {
            Context = context;
        }

        public async ValueTask CreateOrder(OrderAggregate order)
        {
            await Context.AddAsync(order);
            foreach (var item in order.OrderDetails)
            {
                await Context.AddAsync(new OrderDetail
                {
                    Order = order,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                });
            }
        }

        public async ValueTask SaveChanges()
        {
          await Context.SaveChangesAsync();
        }
    }
}
