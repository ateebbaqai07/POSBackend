using POSInterface;
using POSModel;
using POSRepository;
using POSRepository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Tracer;

namespace POSLibrary.Services
{
    public class SupplierService : ISupplierService
    {
        public ResponseDTO<SupplierModel> GetSupplier(int id)
        {
            ResponseDTO<SupplierModel> respDTO = new ResponseDTO<SupplierModel>();
            try
            {
                ISupplierRepository repo = new RepositoryProvider().GetSupplierRepositoy();

                respDTO = repo.GetSupplier(id);

                if (respDTO.DTO == null)
                {
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "No Record Found" });
                }
                else
                {
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                    respDTO.Result = true;
                }
            }
            catch (Exception ex)
            {
                respDTO.ResponseCode = "-1";
                respDTO.ErrorMessages.Add(new ErrorMessage { Message = "SupplierService" + "/GetSupplier" + ex.Message });
            }
            return respDTO;
        }

        public ResponseDTO<string> updateSupplierInfo(SupplierModel bin)
        {
            using (FuncTrace trace = new FuncTrace("CustomerServices", "updateCustomerInfo"))
            {
                ResponseDTO<string> respDTO = new ResponseDTO<string>();
                try
                {
                    ISupplierRepository repo = new RepositoryProvider().GetSupplierRepositoy();

                    respDTO = repo.updateSupplierInfo(bin);

                    if (respDTO.ResponseCode == "9000")
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Insert or Update Failed" });
                    }
                    else
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                        respDTO.Result = true;
                    }
                }
                catch (Exception ex)
                {
                    respDTO.ResponseCode = "-1";
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "SupplierService" + "/updateSupplierInfo" + ex.Message });
                }
                return respDTO;
            }
        }
    }
}
