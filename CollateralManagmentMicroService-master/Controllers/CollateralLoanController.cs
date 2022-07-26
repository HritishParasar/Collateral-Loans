using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMService.Models;
using CMService.Repository;
using CMService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollateralLoanController : ControllerBase
    {

        private readonly ICollateralServices _collateralServices;

        public CollateralLoanController(ICollateralServices collateralServices)
        {
            _collateralServices = collateralServices;
        }


        [HttpGet("CashDeposits")]
        public ActionResult GetCollateralsCD(int loanId)
        {
            if (loanId < 0)
            {
                return BadRequest("Invalid LoanId");
            }

            if (loanId >= 100 && loanId < 199)
            {
                return Ok(_collateralServices.GetCollateralsCashDeposits(loanId));
            }

            return NoContent();
        }

        [HttpGet("RealEstates")]
        public ActionResult GetCollateralsRE(int loanId)
        {
            if (loanId < 0)
            {
                return BadRequest("Invalid LoanId");
            }

            if (loanId >= 200 && loanId < 299)
            {
                return Ok(_collateralServices.GetCollateralsRealEstates(loanId));
            }

            return NoContent();
        }


        [HttpPost("SaveCollateralsCashDeposit")]
        public ActionResult SaveCollateralsCashDeposit([FromBody] CollateralLoanCashDeposit collateralLoanCashDeposit)
        {
            if (ModelState.IsValid)
            {  
                var status = _collateralServices.SaveCollaterals(collateralLoanCashDeposit);
                if (status == true)
                {
                    return Ok("Successfully Added");
                }
                else
                {
                    return NoContent();
                }
            }
            else
            {
                return BadRequest("Unable to Save");
            }
        }


        [HttpPost("SaveCollateralsRealEstate")]
        public ActionResult SaveCollateralsRealEstate([FromBody] CollateralLoanRealEstate collateralLoanRealEstate)
        {
            if (ModelState.IsValid)
            {
                var status = _collateralServices.SaveCollaterals(collateralLoanRealEstate);
                if (status == true)
                {
                    return Content("Success");
                }
                else
                {
                    return NoContent();
                }
            }
            else
            {
                return BadRequest("Unable to Save");
            }
        }
    }
}