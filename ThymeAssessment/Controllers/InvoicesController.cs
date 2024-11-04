using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThymeAssessment.Models;
using ThymeAssessment.Service.Interaces;

namespace ThymeAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly ICustomerInvoiceService _customerInvoiceService;

        public InvoicesController(ICustomerInvoiceService customerInvoiceService)
        {
            _customerInvoiceService = customerInvoiceService;
        }
        // GET: api/customers
        [HttpGet("getcustomerinvoices/{customerid:int}")]
        public async Task<IActionResult> GetAllCustomers(int customerid)
        {
            var response = await _customerInvoiceService.GetCustomerInvoices(customerid);
            return response.Success ? Ok(response) : BadRequest(response);
        }


        // POST: api/customers/addcustomer
        [HttpPost("addcustomerinvoice")]
        public async Task<IActionResult> AddInvoice([FromBody] InvoiceDTO invoiceDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseModel
                {
                    Success = false,
                    Message = "Invalid Invoice data.",
                    Data = null
                });
            }

            var response = await _customerInvoiceService.AddCustomerInvoice(invoiceDTO);
            return response.Success ? Ok(response) : NotFound(response);
             
        }
         
        [HttpPut("updateinvoice")]
        public async Task<IActionResult> UpdateCustomer([FromBody] InvoiceDTO invoiceDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseModel
                {
                    Success = false,
                    Message = "Invalid customer Invoice data.",
                    Data = null
                });
            }

            var response = await _customerInvoiceService.UpdateCustomerInvoice(invoiceDTO);
            return response.Success ? Ok(response) : NotFound(response);
        }
         
        [HttpDelete("deleteinvoice")]
        public async Task<IActionResult> DeleteCustomer(InvoiceDTO invoiceDTO)
        {
            var response = await _customerInvoiceService.DeleteCustomerInvoice(invoiceDTO);
            return response.Success ? NoContent() : NotFound(response);
        }
         


    }
}
