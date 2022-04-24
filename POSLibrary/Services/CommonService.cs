using POSInterface;
using POSModel;
using POSRepository;
using POSRepository.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Tracer;

namespace POSLibrary.Services
{
    public class CommonService : ICommonService
    {
        public ResponseDTO<LoginModel> GetLoginUserDetail(string loginID, string password)
        {
            using (FuncTrace trace = new FuncTrace("CommonService", "GetLoginUserDetail"))
            {
                ResponseDTO<LoginModel> respDTO = new ResponseDTO<LoginModel>();
                try
                {
                    ICommonRepository repo = new RepositoryProvider().GetCommonRepository();
                    
                    respDTO = repo.GetLogiUserDetail(loginID,password);

                    if (respDTO.DTO == null)
                    {
                        respDTO.ResponseCode = "-1";
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "User Name or Password is incorrect" });
                    }
                    else
                    {
                        respDTO.ResponseCode = "0";
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                        respDTO.Result = true;
                    }
                }
                catch (Exception ex)
                {
                    respDTO.ResponseCode = "-1";
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "CommonService" + "/GetLogiUserDetail" + ex.Message });
                }
                return respDTO;
            }
        }
    }
}
