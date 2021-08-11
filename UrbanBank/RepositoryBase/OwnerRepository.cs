using System;
using System.Collections.Generic;
using System.Text;
using UBContracts;
using UBEntities;
using UBEntities.Models;

namespace RepositoryBase
{
    public class OwnerRepository : RepositoryBase<Owner>,IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {

        }
    }
}
