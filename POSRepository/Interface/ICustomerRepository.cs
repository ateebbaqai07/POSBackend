using POSModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSRepository.Interface
{
    public interface ICustomerRepository
    {
        public ResponseDTO<string> updateBusinessType(BusinessTypeModel bin);


        public ResponseDTO<List<BusinessTypeModel>> GetBusinessTypes();


        public ResponseDTO<string> updateCity(CityModel bin);


        public ResponseDTO<List<CityModel>> GetCities();



        public ResponseDTO<string> updateArea(AreaModel bin);


        public ResponseDTO<List<AreaModel>> GetAreas();


        public ResponseDTO<string> updateCountry(CountryModel bin);


        public ResponseDTO<List<CountryModel>> GetCountries();



        public ResponseDTO<string> updateCustomerInfo(CustomerModel bin);


        public ResponseDTO<CustomerModel> GetCustomer(int id);



        public ResponseDTO<List<EmployeeModel>> GetEmployee();


        public ResponseDTO<List<BranchInfoModel>> GetBranch();



        public ResponseDTO<OpeningBalanceModel> GetOpeningBalance(decimal accountCode);


        public ResponseDTO<string> updateOpeningBalance(OpeningBalanceModel bin);
         
    }
}
