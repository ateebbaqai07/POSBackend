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
    public class CustomerServices : ICustomerServices
    {
        public ResponseDTO<List<AreaModel>> GetAreas()
        {
            using (FuncTrace trace = new FuncTrace("CustomerServices", "GetAreas"))
            {
                ResponseDTO<List<AreaModel>> respDTO = new ResponseDTO<List<AreaModel>>();
                try
                {
                    ICustomerRepository repo = new RepositoryProvider().GetCustomerRepository();

                    respDTO = repo.GetAreas();

                    if (respDTO.DTO.Count == 0)
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
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "CustomerServices" + "/GetAreas" + ex.Message });
                }
                return respDTO;
            }

        }

        public ResponseDTO<List<BranchInfoModel>> GetBranch()
        {
            using (FuncTrace trace = new FuncTrace("CustomerServices", "GetBranch"))
            {
                ResponseDTO<List<BranchInfoModel>> respDTO = new ResponseDTO<List<BranchInfoModel>>();
                try
                {
                    ICustomerRepository repo = new RepositoryProvider().GetCustomerRepository();

                    respDTO = repo.GetBranch();

                    if (respDTO.DTO.Count == 0)
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
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "CustomerServices" + "/GetBranch" + ex.Message });
                }
                return respDTO;
            }

        }

        public ResponseDTO<List<BusinessTypeModel>> GetBusinessTypes()
        {
            using (FuncTrace trace = new FuncTrace("CustomerServices", "GetBusinessTypes"))
            {
                ResponseDTO<List<BusinessTypeModel>> respDTO = new ResponseDTO<List<BusinessTypeModel>>();
                try
                {
                    ICustomerRepository repo = new RepositoryProvider().GetCustomerRepository();

                    respDTO = repo.GetBusinessTypes();

                    if (respDTO.DTO.Count == 0)
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
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "CustomerServices" + "/GetBusinessTypes" + ex.Message });
                }
                return respDTO;
            }

        }

        public ResponseDTO<List<CityModel>> GetCities()
        {
            using (FuncTrace trace = new FuncTrace("CustomerServices", "GetCities"))
            {
                ResponseDTO<List<CityModel>> respDTO = new ResponseDTO<List<CityModel>>();
                try
                {
                    ICustomerRepository repo = new RepositoryProvider().GetCustomerRepository();

                    respDTO = repo.GetCities();

                    if (respDTO.DTO.Count == 0)
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
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "CustomerServices" + "/GetCities" + ex.Message });
                }
                return respDTO;
            }

        }

        public ResponseDTO<List<CountryModel>> GetCountries()
        {
            using (FuncTrace trace = new FuncTrace("CustomerServices", "GetCountries"))
            {
                ResponseDTO<List<CountryModel>> respDTO = new ResponseDTO<List<CountryModel>>();
                try
                {
                    ICustomerRepository repo = new RepositoryProvider().GetCustomerRepository();

                    respDTO = repo.GetCountries();

                    if (respDTO.DTO.Count == 0)
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
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "CustomerServices" + "/GetCountries" + ex.Message });
                }
                return respDTO;
            }

        }

        public ResponseDTO<CustomerModel> GetCustomer(int id)
        {
            using (FuncTrace trace = new FuncTrace("CustomerServices", "GetCustomer"))
            {
                ResponseDTO<CustomerModel> respDTO = new ResponseDTO<CustomerModel>();
                try
                {
                    ICustomerRepository repo = new RepositoryProvider().GetCustomerRepository();

                    respDTO = repo.GetCustomer(id);

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
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "CustomerServices" + "/GetCustomer" + ex.Message });
                }
                return respDTO;
            }

        }

        public ResponseDTO<List<EmployeeModel>> GetEmployee()
        {
            using (FuncTrace trace = new FuncTrace("CustomerServices", "GetEmployee"))
            {
                ResponseDTO<List<EmployeeModel>> respDTO = new ResponseDTO<List<EmployeeModel>>();
                try
                {
                    ICustomerRepository repo = new RepositoryProvider().GetCustomerRepository();

                    respDTO = repo.GetEmployee();

                    if (respDTO.DTO.Count == 0)
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
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "CustomerServices" + "/GetEmployee" + ex.Message });
                }
                return respDTO;
            }

        }

        public ResponseDTO<OpeningBalanceModel> GetOpeningBalance(decimal accountCode)
        {
            using (FuncTrace trace = new FuncTrace("CustomerServices", "GetOpeningBalance"))
            {
                ResponseDTO<OpeningBalanceModel> respDTO = new ResponseDTO<OpeningBalanceModel>();
                try
                {
                    ICustomerRepository repo = new RepositoryProvider().GetCustomerRepository();

                    respDTO = repo.GetOpeningBalance(accountCode);

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
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "CustomerServices" + "/GetOpeningBalance" + ex.Message });
                }
                return respDTO;
            }

        }

        public ResponseDTO<string> updateArea(AreaModel bin)
        {
            using (FuncTrace trace = new FuncTrace("CustomerServices", "updateArea"))
            {
                ResponseDTO<string> respDTO = new ResponseDTO<string>();
                try
                {
                    ICustomerRepository repo = new RepositoryProvider().GetCustomerRepository();

                    respDTO = repo.updateArea(bin);

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
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "CustomerServices" + "/updateArea" + ex.Message });
                }
                return respDTO;
            }
        }

        public ResponseDTO<string> updateBusinessType(BusinessTypeModel bin)
        {
            using (FuncTrace trace = new FuncTrace("CustomerServices", "updateBusinessType"))
            {
                ResponseDTO<string> respDTO = new ResponseDTO<string>();
                try
                {
                    ICustomerRepository repo = new RepositoryProvider().GetCustomerRepository();

                    respDTO = repo.updateBusinessType(bin);

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
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "CustomerServices" + "/updateBusinessType" + ex.Message });
                }
                return respDTO;
            }

        }

        public ResponseDTO<string> updateCity(CityModel bin)
        {
            using (FuncTrace trace = new FuncTrace("CustomerServices", "updateCity"))
            {
                ResponseDTO<string> respDTO = new ResponseDTO<string>();
                try
                {
                    ICustomerRepository repo = new RepositoryProvider().GetCustomerRepository();

                    respDTO = repo.updateCity(bin);

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
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "CustomerServices" + "/updateCity" + ex.Message });
                }
                return respDTO;
            }

        }

        public ResponseDTO<string> updateCountry(CountryModel bin)
        {
            using (FuncTrace trace = new FuncTrace("CustomerServices", "updateCountry"))
            {
                ResponseDTO<string> respDTO = new ResponseDTO<string>();
                try
                {
                    ICustomerRepository repo = new RepositoryProvider().GetCustomerRepository();

                    respDTO = repo.updateCountry(bin);

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
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "CustomerServices" + "/updateCountry" + ex.Message });
                }
                return respDTO;
            }

        }

        public ResponseDTO<string> updateCustomerInfo(CustomerModel bin)
        {
            using (FuncTrace trace = new FuncTrace("CustomerServices", "updateCustomerInfo"))
            {
                ResponseDTO<string> respDTO = new ResponseDTO<string>();
                try
                {
                    ICustomerRepository repo = new RepositoryProvider().GetCustomerRepository();

                    respDTO = repo.updateCustomerInfo(bin);

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
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "CustomerServices" + "/updateCustomerInfo" + ex.Message });
                }
                return respDTO;
            }

        }

        public ResponseDTO<string> updateOpeningBalance(OpeningBalanceModel bin)
        {
            using (FuncTrace trace = new FuncTrace("CustomerServices", "updateOpeningBalance"))
            {
                ResponseDTO<string> respDTO = new ResponseDTO<string>();
                try
                {
                    ICustomerRepository repo = new RepositoryProvider().GetCustomerRepository();
                    if(bin.openingType == 'D')
                    {
                        bin.amount = bin.amount;
                    }
                    else if(bin.openingType == 'C')
                    {
                        bin.amount = - bin.amount;
                    }
                    else
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Please provide valid opening type" });
                        return respDTO;
                    }

                    respDTO = repo.updateOpeningBalance(bin);

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
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "CustomerServices" + "/updateOpeningBalance" + ex.Message });
                }
                return respDTO;
            }

        }
    }
}
