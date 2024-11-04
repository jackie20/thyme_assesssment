using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThymeAssessment.Models;
using ThymeAssessment.Service.Interaces;

namespace ThymeAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        // GET: api/customers
        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var response = await _customerService.GetAllCustomersAsync();
            return response.Success ? Ok(response) : BadRequest(response);
        }

        // GET: api/customers/getcustomer/{id}
        [HttpGet("getcustomer/{id:int}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var response = await _customerService.GetCustomerByIdAsync(id);
            return response.Success ? Ok(response) : NotFound(response);
        }

        // POST: api/customers/addcustomer
        [HttpPost("addcustomer")]
        public async Task<IActionResult> AddCustomer([FromBody] Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseModel
                {
                    Success = false,
                    Message = "Invalid customer data.",
                    Data = null
                });
            }

            var response = await _customerService.AddCustomerAsync(customer);
            return response.Success ? CreatedAtAction(nameof(GetCustomerById), new { id = customer.CustomerID }, response) : BadRequest(response);
        }

        // PUT: api/customers/updatecustomer/{id}
        [HttpPut("updatecustomer/{id:int}")]
        public async Task<IActionResult> UpdateCustomer(int id, [FromBody] Customer customer)
        {
            if (id != customer.CustomerID || !ModelState.IsValid)
            {
                return BadRequest(new ResponseModel
                {
                    Success = false,
                    Message = "Invalid customer data.",
                    Data = null
                });
            }

            var response = await _customerService.UpdateCustomerAsync(customer);
            return response.Success ? Ok(response) : NotFound(response);
        }

        // DELETE: api/customers/deletecustomer/{id}
        [HttpDelete("deletecustomer/{id:int}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var response = await _customerService.DeleteCustomerAsync(id);
            return response.Success ? NoContent() : NotFound(response);
        }
    }
}
