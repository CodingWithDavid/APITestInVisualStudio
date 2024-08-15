using Microsoft.AspNetCore.Mvc;
using SamplesWithHTTPFiles.Models;

namespace SamplesWithHTTPFiles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        private static List<Order> orders = new List<Order>
        {
            new Order
            {
                OrderId = 1,
                CustomerId = 1,
                OrderDate = DateTime.Now,
                ShippingAddress = "123 Main St, Anytown, USA",
                TotalAmount = 199.99m,
                Items = new List<OrderItem>
                {
                    new OrderItem { ProductId = 1, ProductName = "Laptop", Quantity = 1, UnitPrice = 999.99m },
                    new OrderItem { ProductId = 2, ProductName = "Mouse", Quantity = 2, UnitPrice = 49.99m }
                }
            }
        };

        // GET: api/orders
        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            return Ok(orders);
        }

        // GET: api/orders/1
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        // POST: api/orders
        [HttpPost]
        public ActionResult<Order> CreateOrder([FromBody] Order order)
        {
            if (order == null)
            {
                return BadRequest();
            }

            order.OrderId = orders.Max(o => o.OrderId) + 1; // Simple auto-increment for demonstration
            orders.Add(order);

            return CreatedAtAction(nameof(GetOrder), new { id = order.OrderId }, order);
        }

        // PUT: api/orders/1
        [HttpPut("{id}")]
        public ActionResult UpdateOrder(int id, [FromBody] Order updatedOrder)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            // Update the order details
            order.CustomerId = updatedOrder.CustomerId;
            order.OrderDate = updatedOrder.OrderDate;
            order.ShippedDate = updatedOrder.ShippedDate;
            order.ShippingAddress = updatedOrder.ShippingAddress;
            order.TotalAmount = updatedOrder.TotalAmount;
            order.Items = updatedOrder.Items;

            return NoContent(); // Standard response for a successful update
        }

        // DELETE: api/orders/1
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            orders.Remove(order);
            return NoContent(); // Standard response for a successful deletion
        }
    }
}

