using System;
using System.Collections.Generic;
using System.Text;
using UBEntities.Models;

namespace UBContracts
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        IEnumerable<Account> AccountsByOwner(Guid ownerId);
    }
}
