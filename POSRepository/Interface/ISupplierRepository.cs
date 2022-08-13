using POSModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSRepository.Interface
{
    public interface ISupplierRepository
    {
        public ResponseDTO<string> updateSupplierInfo(SupplierModel bin);


        public ResponseDTO<SupplierModel> GetSupplier(int id);
    }
}
