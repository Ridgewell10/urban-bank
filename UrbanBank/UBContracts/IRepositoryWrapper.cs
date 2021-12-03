using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UBContracts
{
    public  interface IRepositoryWrapper
    {
        IOwnerRepository Owner { get; }
        IAccountRepository Account { get; }
        Task SaveAsync();
    }
}
