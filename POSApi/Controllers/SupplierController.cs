using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POSModel;
using POSServiceProvider;

namespace POSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        [HttpGet]
        [Route("[action]")]
        public ResponseDTO<SupplierModel> GetSupplier(int id)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetSupplierService().GetSupplier(id);
        }

        [HttpPost]
        [Route("[action]")]
        public ResponseDTO<string> updateSupplierInfo(SupplierModel bin)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetSupplierService().updateSupplierInfo(bin);
        }
    }
}
