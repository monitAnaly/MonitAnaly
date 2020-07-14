using Concrats;
using Data.Models.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Concrats
{
    public interface IErrorRepository : IUnitOfWork<Error>
    {
    }
}
