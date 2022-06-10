using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POSModel;
using POSServiceProvider;
using System.Collections.Generic;

namespace POSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        [Route("[action]")]
        public ResponseDTO<List<AreaModel>> GetAreas()
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetCustomerServices().GetAreas();

        }
        [HttpGet]
        [Route("[action]")]
        public ResponseDTO<List<BranchInfoModel>> GetBranch()
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetCustomerServices().GetBranch();
        }
        [HttpGet]
        [Route("[action]")]
        public ResponseDTO<List<BusinessTypeModel>> GetBusinessTypes()
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetCustomerServices().GetBusinessTypes();
        }
        [HttpGet]
        [Route("[action]")]
        public ResponseDTO<List<CityModel>> GetCities()
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetCustomerServices().GetCities();
        }
        [HttpGet]
        [Route("[action]")]
        public ResponseDTO<List<CountryModel>> GetCountries()
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetCustomerServices().GetCountries();
        }
        [HttpGet]
        [Route("[action]")]
        public ResponseDTO<CustomerModel> GetCustomer(int id)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetCustomerServices().GetCustomer(id);
        }
        [HttpGet]
        [Route("[action]")]
        public ResponseDTO<List<EmployeeModel>> GetEmployee()
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetCustomerServices().GetEmployee();
        }
        [HttpGet]
        [Route("[action]")]
        public ResponseDTO<OpeningBalanceModel> GetOpeningBalance(decimal accountCode)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetCustomerServices().GetOpeningBalance(accountCode);
        }

        [HttpPost]
        [Route("[action]")]
        public ResponseDTO<string> updateArea(AreaModel bin)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetCustomerServices().updateArea(bin);
        }

        [HttpPost]
        [Route("[action]")]
        public ResponseDTO<string> updateBusinessType(BusinessTypeModel bin)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetCustomerServices().updateBusinessType(bin);
        }

        [HttpPost]
        [Route("[action]")]
        public ResponseDTO<string> updateCity(CityModel bin)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetCustomerServices().updateCity(bin);
        }

        [HttpPost]
        [Route("[action]")]
        public ResponseDTO<string> updateCountry(CountryModel bin)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetCustomerServices().updateCountry(bin);
        }

        [HttpPost]
        [Route("[action]")]
        public ResponseDTO<string> updateCustomerInfo(CustomerModel bin)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetCustomerServices().updateCustomerInfo(bin);
        }

        [HttpPost]
        [Route("[action]")]
        public ResponseDTO<string> updateOpeningBalance(OpeningBalanceModel bin)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetCustomerServices().updateOpeningBalance(bin);
        }
    }
}
