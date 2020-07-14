using Analy.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Analy.Concrats
{
    public interface IExceptionError
    {
        [Post("/ExceptionError")]
        Task ExceptionError(Error json);
    }
}
