using System;
using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<Account> AccountsByOwner(Guid ownerId)
        {
            return FindByCondition(a => a.OwnerId.Equals(ownerId)).ToList();
        }
    }
}
