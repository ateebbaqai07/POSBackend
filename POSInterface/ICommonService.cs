using POSModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSInterface
{
    public interface ICommonService
    {
        public ResponseDTO<LoginModel> GetLoginUserDetail(string loginID, string password);
    }
}
