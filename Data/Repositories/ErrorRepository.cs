using Data.Models.Context;
using Domain.Concrats;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public class ErrorRepository : UnitOfWork<Error>, IErrorRepository
    {
    }
}
