using Analy.Concrats;
using Analy.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Analy.Service
{
    public static class Analytics
    {
        public static void UseExceptionAnalytics(this IApplicationBuilder app, string key)
        {
            app.UseExceptionHandler(builder =>
            {
                builder.Run(async Context =>
                {
                    var exceptionHandleFeature = Context.Features.Get<IExceptionHandlerFeature>();

                    if (exceptionHandleFeature != null)
                    {
                        Context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        Context.Response.ContentType = "application/json";

                        var error = new Error
                        {
                            Key = key,
                            StackTrace = exceptionHandleFeature.Error.StackTrace,
                            Source = exceptionHandleFeature.Error.Source,
                            Path = "/"
                        };

                        await Execute.SendException(error);
                    }

                });

            });
        }

    }
}
