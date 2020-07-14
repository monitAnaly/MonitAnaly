using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Concrats;
using Data.Models.Context;
using Domain.Models.Context;
using Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Monit.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExceptionErrorController : ControllerBase
    {
        private readonly IUnitOfWork<Account> unitOfWorkAccount;
        private readonly IUnitOfWork<Error> unitOfWorkError;
        public ExceptionErrorController()
        {
            unitOfWorkAccount = new AccountRepository();
            unitOfWorkError = new ErrorRepository();
        }
        [HttpPost]
        public IActionResult Post(Error model)
        {
            try
            {
                if (model == null)
                    throw new Exception("model is null");

                if (model.Key == null)
                    throw new Exception("key is required");

                unitOfWorkError.Add(model);
                unitOfWorkError.Commit();

                return Ok("Sucessfully!!");
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}