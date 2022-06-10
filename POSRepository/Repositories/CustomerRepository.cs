using POSModel;
using POSRepository.Common;
using POSRepository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Tracer;

namespace POSRepository.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public ResponseDTO<string> updateBusinessType(BusinessTypeModel bin)
        {
            using (FuncTrace trace = new FuncTrace("CustomerRepository", "updateBusinessType"))
            {
                ResponseDTO<string> responseDTO = new ResponseDTO<string>();
                List<Parameter> _param = new List<Parameter>();

                //Set Param
                _param.Add(new Parameter { ParameterName = "@id", Value = bin.type_code, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@type_name", Value = bin.type_name, DbType = ParameterDbType.String });


                DataSet ds = new ClsExecute().GetDataSet("sp_update_business_type", CommandType.StoredProcedure, _param);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    responseDTO.ResponseCode = SafeConvert.ToString(ds.Tables[0].Rows[0]["retValue"]);

                }

                return responseDTO;
            }
        }

        public ResponseDTO<List<BusinessTypeModel>> GetBusinessTypes()
        {
            using (FuncTrace trace = new FuncTrace("CustomerRepository", "GetBusinessType"))
            {
                ResponseDTO<List<BusinessTypeModel>> responseDTO = new ResponseDTO<List<BusinessTypeModel>>();
                List<Parameter> _param = new List<Parameter>();


                DataSet ds = new ClsExecute().GetDataSet("SP_GET_BUSINESS_TYPE", CommandType.StoredProcedure, _param);

                List<BusinessTypeModel> l_field = new List<BusinessTypeModel>();
                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        BusinessTypeModel l_obj = new BusinessTypeModel();
                        l_obj.type_code = SafeConvert.ToDecimal(row["type_code"]);
                        l_obj.type_name = SafeConvert.ToString(row["type_name"]);
                        l_field.Add(l_obj);

                    }

                }
                responseDTO.DTO = l_field;
                responseDTO.Result = true;

                return responseDTO;
            }
        }

        public ResponseDTO<string> updateCity(CityModel bin)
        {
            using (FuncTrace trace = new FuncTrace("CustomerRepository", "updateCity"))
            {
                ResponseDTO<string> responseDTO = new ResponseDTO<string>();
                List<Parameter> _param = new List<Parameter>();

                //Set Param
                _param.Add(new Parameter { ParameterName = "@id", Value = bin.city_code, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@city_name", Value = bin.city_name, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@branch_id", Value = bin.branch_id, DbType = ParameterDbType.String });

                DataSet ds = new ClsExecute().GetDataSet("sp_update_city", CommandType.StoredProcedure, _param);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    responseDTO.ResponseCode = SafeConvert.ToString(ds.Tables[0].Rows[0]["retValue"]);

                }

                return responseDTO;
            }
        }

        public ResponseDTO<List<CityModel>> GetCities()
        {
            using (FuncTrace trace = new FuncTrace("CustomerRepository", "GetCities"))
            {
                ResponseDTO<List<CityModel>> responseDTO = new ResponseDTO<List<CityModel>>();
                List<Parameter> _param = new List<Parameter>();


                DataSet ds = new ClsExecute().GetDataSet("SP_GET_CITY", CommandType.StoredProcedure, _param);

                List<CityModel> l_field = new List<CityModel>();
                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        CityModel l_obj = new CityModel();
                        l_obj.city_code = SafeConvert.ToDecimal(row["city_code"]);
                        l_obj.city_name = SafeConvert.ToString(row["city_name"]);
                        l_obj.branch_id = SafeConvert.ToString(row["branch_id"]);
                        l_field.Add(l_obj);

                    }

                }
                responseDTO.DTO = l_field;
                responseDTO.Result = true;

                return responseDTO;
            }
        }


        public ResponseDTO<string> updateArea(AreaModel bin)
        {
            using (FuncTrace trace = new FuncTrace("CustomerRepository", "updateArea"))
            {
                ResponseDTO<string> responseDTO = new ResponseDTO<string>();
                List<Parameter> _param = new List<Parameter>();

                //Set Param
                _param.Add(new Parameter { ParameterName = "@id", Value = bin.area_code, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@area_name", Value = bin.area_name, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@branch_id", Value = bin.branch_id, DbType = ParameterDbType.String });

                DataSet ds = new ClsExecute().GetDataSet("sp_update_area", CommandType.StoredProcedure, _param);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    responseDTO.ResponseCode = SafeConvert.ToString(ds.Tables[0].Rows[0]["retValue"]);

                }

                return responseDTO;
            }
        }

        public ResponseDTO<List<AreaModel>> GetAreas()
        {
            using (FuncTrace trace = new FuncTrace("CustomerRepository", "GetAreas"))
            {
                ResponseDTO<List<AreaModel>> responseDTO = new ResponseDTO<List<AreaModel>>();
                List<Parameter> _param = new List<Parameter>();


                DataSet ds = new ClsExecute().GetDataSet("SP_GET_AREA", CommandType.StoredProcedure, _param);

                List<AreaModel> l_field = new List<AreaModel>();
                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        AreaModel l_obj = new AreaModel();
                        l_obj.area_code = SafeConvert.ToDecimal(row["area_code"]);
                        l_obj.area_name = SafeConvert.ToString(row["area_name"]);
                        l_obj.branch_id = SafeConvert.ToString(row["branch_id"]);
                        l_field.Add(l_obj);

                    }

                }
                responseDTO.DTO = l_field;
                responseDTO.Result = true;

                return responseDTO;
            }
        }

        public ResponseDTO<string> updateCountry(CountryModel bin)
        {
            using (FuncTrace trace = new FuncTrace("CustomerRepository", "updateArea"))
            {
                ResponseDTO<string> responseDTO = new ResponseDTO<string>();
                List<Parameter> _param = new List<Parameter>();

                //Set Param
                _param.Add(new Parameter { ParameterName = "@id", Value = bin.country_code, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@country_name", Value = bin.country_name, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@branch_id", Value = bin.branch_id, DbType = ParameterDbType.String });
                DataSet ds = new ClsExecute().GetDataSet("sp_update_country", CommandType.StoredProcedure, _param);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    responseDTO.ResponseCode = SafeConvert.ToString(ds.Tables[0].Rows[0]["retValue"]);

                }

                return responseDTO;
            }
        }

        public ResponseDTO<List<CountryModel>> GetCountries()
        {
            using (FuncTrace trace = new FuncTrace("CustomerRepository", "GetAreas"))
            {
                ResponseDTO<List<CountryModel>> responseDTO = new ResponseDTO<List<CountryModel>>();
                List<Parameter> _param = new List<Parameter>();


                DataSet ds = new ClsExecute().GetDataSet("SP_GET_COUNTRY", CommandType.StoredProcedure, _param);

                List<CountryModel> l_field = new List<CountryModel>();
                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        CountryModel l_obj = new CountryModel();
                        l_obj.country_code = SafeConvert.ToDecimal(row["country_code"]);
                        l_obj.country_name = SafeConvert.ToString(row["country_name"]);
                        l_obj.branch_id = SafeConvert.ToString(row["branch_id"]);
                        l_field.Add(l_obj);

                    }

                }
                responseDTO.DTO = l_field;
                responseDTO.Result = true;

                return responseDTO;
            }
        }


        public ResponseDTO<string> updateCustomerInfo(CustomerModel bin)
        {
            using (FuncTrace trace = new FuncTrace("CustomerRepository", "updateArea"))
            {
                ResponseDTO<string> responseDTO = new ResponseDTO<string>();
                List<Parameter> _param = new List<Parameter>();

                //Set Param
                _param.Add(new Parameter { ParameterName = "@id", Value = bin.cust_code, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@cust_name", Value = bin.cust_name, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cust_ph_no", Value = bin.cust_ph_no, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cust_mob_no", Value = bin.cust_mob_no, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cust_address1", Value = bin.cust_address1, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cust_address2", Value = bin.cust_address2, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cust_modify", Value = bin.cust_modify, DbType = ParameterDbType.Int32  });
                _param.Add(new Parameter { ParameterName = "@master_code", Value = bin.master_code, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@cust_active", Value = bin.cust_active, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@cust_current_bal", Value = bin.cust_current_bal, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@branch_id", Value = bin.branch_id, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cust_email", Value = bin.cust_email, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cust_cnic", Value = bin.cust_cnic, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cust_area", Value = bin.cust_area, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cust_city", Value = bin.cust_city, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cust_country", Value = bin.cust_country, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@salesman_code", Value = bin.salesman_code, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@cust_type", Value = bin.cust_type, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cust_terms", Value = bin.cust_terms, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cust_disc_per", Value = bin.cust_disc_per, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@price_level", Value = bin.price_level, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@cust_cmp_name", Value = bin.cust_cmp_name, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cust_ntn_no", Value = bin.cust_ntn_no, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cust_sales_tax_reg", Value = bin.cust_sales_tax_reg, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cust_fax", Value = bin.cust_fax, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cust_credit_limit", Value = bin.cust_credit_limit, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@cust_credit_days", Value = bin.cust_credit_days, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@cust_joining_date", Value = bin.cust_joining_date, DbType = ParameterDbType.DateTime });
                _param.Add(new Parameter { ParameterName = "@remarks", Value = bin.remarks, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@search_code", Value = bin.search_code, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cmp_contact", Value = bin.cmp_contact, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@target", Value = bin.target, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@commission", Value = bin.commission, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@target_from", Value = bin.target_from, DbType = ParameterDbType.DateTime });
                _param.Add(new Parameter { ParameterName = "@target_to", Value = bin.target_to, DbType = ParameterDbType.DateTime });
                _param.Add(new Parameter { ParameterName = "@last_inv_type", Value = bin.last_inv_type, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@cust_dng_type", Value = bin.cust_dng_type, DbType = ParameterDbType.Int32 });

                DataSet ds = new ClsExecute().GetDataSet("sp_update_customer", CommandType.StoredProcedure, _param);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    responseDTO.ResponseCode = SafeConvert.ToString(ds.Tables[0].Rows[0]["retValue"]);

                }

                return responseDTO;
            }
        }

        public ResponseDTO<CustomerModel> GetCustomer(int id)
        {
            using (FuncTrace trace = new FuncTrace("CustomerRepository", "GetAreas"))
            {
                ResponseDTO<CustomerModel> responseDTO = new ResponseDTO<CustomerModel>();
                List<Parameter> _param = new List<Parameter>();

                _param.Add(new Parameter { ParameterName = "@id", Value = id, DbType = ParameterDbType.Int32 });
                DataSet ds = new ClsExecute().GetDataSet("SP_GET_CUSTOMER", CommandType.StoredProcedure, _param);

                CustomerModel l_obj = new CustomerModel();
                if (ds.Tables[0].Rows.Count == 1)
                {
                    
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        
                        l_obj.cust_code = SafeConvert.ToDecimal(row["cust_code"]);
                        l_obj.cust_name = SafeConvert.ToString(row["cust_name"]);
                        l_obj.cust_ph_no = SafeConvert.ToString(row["cust_ph_no"]);
                        l_obj.cust_mob_no = SafeConvert.ToString(row["cust_mob_no"]);
                        l_obj.cust_address1 = SafeConvert.ToString(row["cust_address1"]);
                        l_obj.cust_address2 = SafeConvert.ToString(row["cust_address2"]);
                        l_obj.cust_modify = SafeConvert.ToInt32(row["cust_modify"]);
                        l_obj.master_code = SafeConvert.ToInt32(row["master_code"]);
                        l_obj.cust_active = SafeConvert.ToInt32(row["cust_active"]);
                        l_obj.cust_current_bal = SafeConvert.ToDecimal(row["cust_current_bal"]);
                        l_obj.branch_id = SafeConvert.ToString(row["branch_id"]);
                        l_obj.cust_email = SafeConvert.ToString(row["cust_email"]);
                        l_obj.cust_cnic = SafeConvert.ToString(row["cust_cnic"]);
                        l_obj.cust_area = SafeConvert.ToString(row["cust_area"]);
                        l_obj.cust_city = SafeConvert.ToString(row["cust_city"]);
                        l_obj.cust_country = SafeConvert.ToString(row["cust_country"]);
                        l_obj.salesman_code = SafeConvert.ToDecimal(row["salesman_code"]);
                        l_obj.cust_type = SafeConvert.ToString(row["cust_type"]);
                        l_obj.cust_terms = SafeConvert.ToString(row["cust_terms"]);
                        l_obj.cust_disc_per = SafeConvert.ToDecimal(row["cust_disc_per"]);
                        l_obj.price_level = SafeConvert.ToInt32(row["price_level"]);
                        l_obj.cust_cmp_name = SafeConvert.ToString(row["cust_cmp_name"]);
                        l_obj.cust_ntn_no = SafeConvert.ToString(row["cust_ntn_no"]);
                        l_obj.cust_sales_tax_reg = SafeConvert.ToString(row["cust_sales_tax_reg"]);
                        l_obj.cust_fax = SafeConvert.ToString(row["cust_fax"]);
                        l_obj.cust_credit_limit = SafeConvert.ToDecimal(row["cust_credit_limit"]);
                        l_obj.cust_credit_days = SafeConvert.ToDecimal(row["cust_credit_days"]);
                        l_obj.cust_joining_date = SafeConvert.ToDateTime(row["cust_joining_date"]);
                        l_obj.remarks = SafeConvert.ToString(row["remarks"]);
                        l_obj.search_code = SafeConvert.ToString(row["search_code"]);
                        l_obj.cmp_contact = SafeConvert.ToString(row["cmp_contact"]);
                        l_obj.target = SafeConvert.ToDecimal(row["target"]);
                        l_obj.commission = SafeConvert.ToDecimal(row["commission"]);
                        l_obj.target_from = SafeConvert.ToDateTime(row["target_from"]);
                        l_obj.target_to = SafeConvert.ToDateTime(row["target_to"]);
                        l_obj.last_inv_type = SafeConvert.ToInt32(row["last_inv_type"]);
                        l_obj.cust_dng_type = SafeConvert.ToInt32(row["cust_dng_type"]); 
                        

                    }

                }
                responseDTO.DTO = l_obj;
                responseDTO.Result = true;

                return responseDTO;
            }
        }
         

        public ResponseDTO<List<EmployeeModel>> GetEmployee()
        {
            using (FuncTrace trace = new FuncTrace("CustomerRepository", "GetAreas"))
            {
                ResponseDTO<List<EmployeeModel>> responseDTO = new ResponseDTO<List<EmployeeModel>>();
                List<Parameter> _param = new List<Parameter>();

                  DataSet ds = new ClsExecute().GetDataSet("SP_GET_EMPLOYEE", CommandType.StoredProcedure, _param);

                List<EmployeeModel> l_field = new List<EmployeeModel>();
                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        EmployeeModel l_obj = new EmployeeModel();
                        l_obj.emp_code = SafeConvert.ToDecimal(row["emp_code"]);
                        l_obj.emp_name = SafeConvert.ToString(row["emp_name"]);
                        l_obj.last_name = SafeConvert.ToString(row["last_name"]);
                        l_obj.dob = SafeConvert.ToDateTime(row["dob"]);
                        l_obj.ph_no = SafeConvert.ToString(row["ph_no"]);
                        l_obj.mob_no = SafeConvert.ToString(row["mob_no"]);
                        l_obj.cnic = SafeConvert.ToString(row["cnic"]);
                        l_obj.address = SafeConvert.ToString(row["address"]);
                        l_obj.doj = SafeConvert.ToDateTime(row["doj"]);
                        l_obj.branch_id = SafeConvert.ToString(row["branch_id"]);
                        l_obj.designation = SafeConvert.ToString(row["designation"]);
                        l_obj.target = SafeConvert.ToDecimal(row["target"]);
                        l_obj.target_from = SafeConvert.ToDateTime(row["target_from"]);
                        l_obj.taget_to = SafeConvert.ToDateTime(row["taget_to"]);
                        l_obj.commission = SafeConvert.ToDecimal(row["commission"]);
                        l_field.Add(l_obj);

                    }

                }
                responseDTO.DTO = l_field;
                responseDTO.Result = true;

                return responseDTO;
            }
        }

        public ResponseDTO<List<BranchInfoModel>> GetBranch()
        {
            using (FuncTrace trace = new FuncTrace("CustomerRepository", "GetBranch"))
            {
                ResponseDTO<List<BranchInfoModel>> responseDTO = new ResponseDTO<List<BranchInfoModel>>();
                List<Parameter> _param = new List<Parameter>();

                DataSet ds = new ClsExecute().GetDataSet("SP_GET_BRANCH", CommandType.StoredProcedure, _param);

                List<BranchInfoModel> l_field = new List<BranchInfoModel>();
                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        BranchInfoModel l_obj = new BranchInfoModel();
                        l_obj.branch_code = SafeConvert.ToString(row["branch_code"]);
                        l_obj.branch_name = SafeConvert.ToString(row["branch_name"]);
                        l_obj.branch_address = SafeConvert.ToString(row["branch_address"]);
                        l_obj.branch_type = SafeConvert.ToString(row["branch_type"]);
                        l_obj.branch_location = SafeConvert.ToString(row["branch_location"]);
                        l_obj.system_code = SafeConvert.ToDecimal(row["system_code"]);
                        l_field.Add(l_obj);

                    }

                }
                responseDTO.DTO = l_field;
                responseDTO.Result = true;

                return responseDTO;
            }
        }


        public ResponseDTO<OpeningBalanceModel> GetOpeningBalance(decimal accountCode)
        {
            using (FuncTrace trace = new FuncTrace("CustomerRepository", "GetBranch"))
            {
                ResponseDTO< OpeningBalanceModel> responseDTO = new ResponseDTO<OpeningBalanceModel>();
                List<Parameter> _param = new List<Parameter>();

                _param.Add(new Parameter { ParameterName = "@account_code", Value = accountCode, DbType = ParameterDbType.Decimal });

                DataSet ds = new ClsExecute().GetDataSet("SP_GET_OPENING_BALANCE", CommandType.StoredProcedure, _param);

                OpeningBalanceModel l_obj = new OpeningBalanceModel();
                if (ds.Tables[0].Rows.Count == 1 )
                {

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {

                        l_obj.voucher_no = SafeConvert.ToDecimal(row["voucher_no"]);
                        l_obj.voucher_type = SafeConvert.ToDecimal(row["voucher_type"]);
                        l_obj.account_code = SafeConvert.ToDecimal(row["account_code"]);
                        l_obj.account_name = SafeConvert.ToString(row["account_name"]);
                        l_obj.branch_id = SafeConvert.ToString(row["branch_id"]);
                        l_obj.amount = SafeConvert.ToDecimal(row["amount"]);
                        l_obj.open_date = SafeConvert.ToDateTime(row["open_date"]);
                        l_obj.open_datetime = SafeConvert.ToDateTime(row["open_datetime"]);
                        l_obj.master_code = SafeConvert.ToDecimal(row["master_code"]);
                        l_obj.particulars = SafeConvert.ToString(row["particulars"]);
                        

                    }

                }
                responseDTO.DTO = l_obj;
                responseDTO.Result = true;

                return responseDTO;
            }
        }

        public ResponseDTO<string> updateOpeningBalance(OpeningBalanceModel bin)
        {
            using (FuncTrace trace = new FuncTrace("CustomerRepository", "updateArea"))
            {
                ResponseDTO<string> responseDTO = new ResponseDTO<string>();
                List<Parameter> _param = new List<Parameter>();

                //Set Param
                _param.Add(new Parameter { ParameterName = "@voucher_no", Value = bin.voucher_no, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@voucher_type", Value = bin.voucher_type, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@account_code", Value = bin.account_code, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@account_name", Value = bin.account_name, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@branch_id", Value = bin.branch_id, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@amount", Value = bin.amount, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@open_date", Value = bin.open_date, DbType = ParameterDbType.DateTime });
                _param.Add(new Parameter { ParameterName = "@open_datetime", Value = bin.open_datetime, DbType = ParameterDbType.DateTime });
                _param.Add(new Parameter { ParameterName = "@master_code", Value = bin.master_code, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@particulars", Value = bin.particulars, DbType = ParameterDbType.String });
                DataSet ds = new ClsExecute().GetDataSet("sp_update_opening_bal", CommandType.StoredProcedure, _param);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    responseDTO.ResponseCode = SafeConvert.ToString(ds.Tables[0].Rows[0]["retValue"]);

                }

                return responseDTO;
            }
        }

    }
}
