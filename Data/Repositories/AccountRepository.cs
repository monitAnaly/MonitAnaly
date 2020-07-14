using Data.Models.Context;
using Domain.Concrats;
using Domain.Models.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public class AccountRepository : UnitOfWork<Account>, IAccountRepository
    {
    }
}
