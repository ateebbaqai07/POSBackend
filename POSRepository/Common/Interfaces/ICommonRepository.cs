
using POSModel;
using System;
using System.Collections.Generic;
using System.Text;


namespace POSRepository.Common.Interfaces
{
    public interface ICommonRepository
    {
        public ResponseDTO<LoginModel> GetLogiUserDetail(string loginID, string Password);

    }
}
