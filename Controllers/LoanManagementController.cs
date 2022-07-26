using LoanManagementMicroservice.Models;
using LoanManagementMicroservice.Repository;
using LoanManagementMicroservice.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoanManagementMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanManagementController : ControllerBase
    {
        private readonly ILoanDetailsService _loanDetailsService;
        private IHttpClientFactory _httpClientFactory;

        public LoanManagementController(ILoanDetailsService loanDetailsService, IHttpClientFactory httpClientFactory)
        {
            _loanDetailsService = loanDetailsService;
            _httpClientFactory = httpClientFactory;
        }

        //GET api/<LoanManagementController>/101
        [HttpGet]
        public ActionResult GetLoanDetails(int loanId, int customerId)
        {
            if (loanId <= 0 && customerId <= 0)
            {
                return BadRequest("Invalid loan id or customer id");
            }
            if (loanId > 0 && customerId > 0)
            {
                CustomerLoan customerLoan = _loanDetailsService.GetLoanDetails(loanId, customerId);
                if (customerLoan == null)
                {
                    return NoContent();
                }
                else
                {
                    return Ok(customerLoan);
                }
            }
            else
            {
                return NoContent();
            }
        }

        [HttpPost("SaveCD")]
        public async Task<IActionResult> SaveCollaterals([FromBody] CollateralLoanCashDeposit collateralLoanCashDeposit)
        {
            if (ModelState.IsValid)
            {
                HttpClient httpClient = _httpClientFactory.CreateClient();
                httpClient.BaseAddress = new Uri("http://localhost:59286/api/LoanManagement/SaveCD");

                HttpResponseMessage response = httpClient.PostAsJsonAsync(new Uri("https://collateralmanagmentmicroservice.azurewebsites.net/api/CollateralLoan/SaveCollateralsCashDeposit"), collateralLoanCashDeposit).Result;
                if (response.IsSuccessStatusCode)
                {
                    string Status = await response.Content.ReadAsStringAsync();
                    if (Status != null)
                    {
                        return Ok(Status);
                    }
                    else
                    {
                        return NoContent();
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return BadRequest("Unable to Save");
            }
        }

        [HttpPost("SaveRE")]
        public async Task<IActionResult> SaveCollaterals([FromBody] CollateralLoanRealEstate collateralLoanRealEstate)
        {
            if (ModelState.IsValid)
            {
                HttpClient httpClient = _httpClientFactory.CreateClient();
                httpClient.BaseAddress = new Uri("http://localhost:59286/api/LoanManagement/SaveRE");

                HttpResponseMessage response = httpClient.PostAsJsonAsync(new Uri("https://collateralmanagmentmicroservice.azurewebsites.net/api/CollateralLoan/SaveCollateralsRealEstate"), collateralLoanRealEstate).Result;
                if (response.IsSuccessStatusCode)
                {
                    string Status = await response.Content.ReadAsStringAsync();
                    if (Status != null)
                    {
                        return Ok(Status);
                    }
                    else
                    {
                        return NoContent();
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return BadRequest("Unable to Save");
            }
        }
    }
}

