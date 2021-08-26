﻿using Microsoft.AspNetCore.Mvc;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.BLL.Services;
using System;
using System.Threading.Tasks;

namespace MonumentMlyn.WebUI.Controllers
{
    [Route("api/Customer")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerServices _customerServices;

        public CustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        // GET /Customer
        [HttpGet]
        public async Task<IActionResult> GetAllCustomer()
        {
            try
            {
                var customerDto = await _customerServices.GetAllCustomers();
                return Ok(customerDto);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(Guid id)
        {
            try
            {
                var customerResult = await _customerServices.GetCustomerById(id);
                return Ok(customerResult);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] CustomerDto customer)
        {
            try
            {
                if (customer == null)
                {
                    return BadRequest("Customer object is null");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                await _customerServices.CreateCustomer(customer);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(Guid id, [FromBody] CustomerDto customer)
        {
            try
            {
                if (customer == null)
                {
                    return BadRequest("Customer object is null");
                }


                if (!ModelState.IsValid)
                {

                    return BadRequest("Invalid model object");
                }


                var customerEntity = await _customerServices.GetCustomerById(id);

                if (customerEntity == null)
                {
                    return NotFound();
                }

                await _customerServices.UpdateCustomer(id, customer);
                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            try
            {

                var customerEntity = await _customerServices.GetCustomerById(id);

                if (customerEntity == null)
                {
                    return NotFound();
                }

                await _customerServices.DeleteCustomer(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error" + e);
            }
        }
    }
}