using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POSModel;
using POSServiceProvider;

namespace POSApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        [HttpPost]
        public  ResponseDTO<LoginModel> Post(LoginModel Login)
        {
            ServiceProvider sp = new ServiceProvider();
            return  sp.GetCommonService().GetLoginUserDetail(Login.LoginName, Login.Password);
             
        }
    }
}
