using POSModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSInterface
{
   public  interface ISupplierService
    {
        public ResponseDTO<string> updateSupplierInfo(SupplierModel bin); 
        public ResponseDTO<SupplierModel> GetSupplier(int id);
    }
}
