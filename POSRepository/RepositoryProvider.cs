using POSRepository.Common.Interfaces;
using POSRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSRepository
{
    public class RepositoryProvider
    {
        public ICommonRepository GetCommonRepository()
        {
            return new CommonRepository();
        }
    }
}
