using POSRepository.Common.Interfaces;
using POSRepository.Interface;
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

        public IItemRepository GetItemRepository()
        {
            return new ItemRepository();
        }

        public ICustomerRepository GetCustomerRepository()
        {
            return new CustomerRepository();
        }
    }
}
