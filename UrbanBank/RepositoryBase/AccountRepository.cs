using System;
using System.Collections.Generic;
using System.Text;
using UBContracts;
using UBEntities;
using UBEntities.Models;

namespace RepositoryBase
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
