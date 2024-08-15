using Microsoft.AspNetCore.Mvc;
using SamplesWithHTTPFiles.Models;
using SamplesWithHTTPFiles.Service;

namespace SamplesWithHTTPFiles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private static List<Customer> customers = CustomerService.GetCustomers();

        // GET: api/customers
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetCustomers()
        {
            return Ok(customers);
        }

        // GET: api/customers/1
        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomer(int id)
        {
            var customer = customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        // POST: api/customers
        [HttpPost]
        public ActionResult<Customer> CreateCustomer([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }

            customer.Id = customers.Max(c => c.Id) + 1; // Simple auto-increment for demonstration
            customers.Add(customer);

            return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, customer);
        }

        // PUT: api/customers/1
        [HttpPut("{id}")]
        public ActionResult UpdateCustomer(int id, [FromBody] Customer updatedCustomer)
        {
            var customer = customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            // Update the customer details
            customer.FirstName = updatedCustomer.FirstName;
            customer.LastName = updatedCustomer.LastName;
            customer.Email = updatedCustomer.Email;
            customer.PhoneNumber = updatedCustomer.PhoneNumber;
            customer.Address = updatedCustomer.Address;
            customer.DateOfBirth = updatedCustomer.DateOfBirth;

            return NoContent(); // Standard response for a successful update
        }

        // DELETE: api/customers/1
        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(int id)
        {
            var customer = customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            customers.Remove(customer);
            return NoContent(); // Standard response for a successful deletion
        }
    }
}

