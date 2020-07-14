using Analy.Concrats;
using Analy.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Polly;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Analy
{
    public static class Execute
    {
        public static async Task SendException(Error error)
        {
            try
            {
                 await Policy
                      .Handle<Exception>()
                      .RetryAsync(1)
                      .ExecuteAsync(async () =>  await RestService.For<IExceptionError>("https://localhost:44363/api").ExceptionError(error))
                      .ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
