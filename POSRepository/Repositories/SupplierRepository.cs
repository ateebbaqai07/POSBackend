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
    public class SupplierRepository : ISupplierRepository
    {
        public ResponseDTO<string> updateSupplierInfo(SupplierModel bin)
        {
            using (FuncTrace trace = new FuncTrace("SupplierRepository", "updateSupplierInfo"))
            {
                ResponseDTO<string> responseDTO = new ResponseDTO<string>();
                List<Parameter> _param = new List<Parameter>();

                //Set Param
                _param.Add(new Parameter { ParameterName = "@supp_code", Value = bin.supp_code, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@supp_name", Value = bin.supp_name, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_ph_no", Value = bin.supp_ph_no, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_mob_no", Value = bin.supp_mob_no, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_cmp_name", Value = bin.supp_cmp_name, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_address1", Value = bin.supp_address1, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_address2", Value = bin.supp_address2, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_cmp_ph_no", Value = bin.supp_cmp_ph_no, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_sales_tax", Value = bin.supp_sales_tax, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_ntn", Value = bin.supp_ntn, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_current_bal", Value = bin.supp_current_bal, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@supp_modify", Value = bin.supp_modify, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@supp_active", Value = bin.supp_active, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@master_code", Value = bin.master_code, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@branch_id", Value = bin.branch_id, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_terms", Value = bin.supp_terms, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_type", Value = bin.supp_type, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_fax", Value = bin.supp_fax, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_cnic", Value = bin.supp_cnic, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_email", Value = bin.supp_email, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_rem", Value = bin.supp_rem, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_search", Value = bin.supp_search, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_area", Value = bin.supp_area, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_city", Value = bin.supp_city, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_country", Value = bin.supp_country, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@supp_joining_date", Value = bin.supp_joining_date, DbType = ParameterDbType.DateTime });

                DataSet ds = new ClsExecute().GetDataSet("sp_update_supplier", CommandType.StoredProcedure, _param);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    responseDTO.ResponseCode = SafeConvert.ToString(ds.Tables[0].Rows[0]["retValue"]);

                }

                return responseDTO;
            }
        }

        public ResponseDTO<SupplierModel> GetSupplier(int id)
        {
            using (FuncTrace trace = new FuncTrace("SupplierRepository", "GetSupplier"))
            {
                ResponseDTO<SupplierModel> responseDTO = new ResponseDTO<SupplierModel>();
                List<Parameter> _param = new List<Parameter>();

                _param.Add(new Parameter { ParameterName = "@id", Value = id, DbType = ParameterDbType.Int32 });
                DataSet ds = new ClsExecute().GetDataSet("SP_GET_SUPPLIER", CommandType.StoredProcedure, _param);

                SupplierModel l_obj = new SupplierModel();
                if (ds.Tables[0].Rows.Count == 1)
                {

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {

                        l_obj.supp_code = SafeConvert.ToDecimal(row["supp_code"]);
                        l_obj.supp_name = SafeConvert.ToString(row["supp_name"]);
                        l_obj.supp_ph_no = SafeConvert.ToString(row["supp_ph_no"]);
                        l_obj.supp_mob_no = SafeConvert.ToString(row["supp_mob_no"]);
                        l_obj.supp_cmp_name = SafeConvert.ToString(row["supp_cmp_name"]);
                        l_obj.supp_address1 = SafeConvert.ToString(row["supp_address1"]);
                        l_obj.supp_address2 = SafeConvert.ToString(row["supp_address2"]);
                        l_obj.supp_cmp_ph_no = SafeConvert.ToString(row["supp_cmp_ph_no"]);
                        l_obj.supp_sales_tax = SafeConvert.ToString(row["supp_sales_tax"]);
                        l_obj.supp_ntn = SafeConvert.ToString(row["supp_ntn"]);
                        l_obj.supp_current_bal = SafeConvert.ToDecimal(row["supp_current_bal"]);
                        l_obj.supp_modify = SafeConvert.ToInt32(row["supp_modify"]);
                        l_obj.supp_active = SafeConvert.ToInt32(row["supp_active"]);
                        l_obj.master_code = SafeConvert.ToInt32(row["master_code"]);
                        l_obj.branch_id = SafeConvert.ToString(row["branch_id"]);
                        l_obj.supp_terms = SafeConvert.ToString(row["supp_terms"]);
                        l_obj.supp_type = SafeConvert.ToString(row["supp_type"]);
                        l_obj.supp_fax = SafeConvert.ToString(row["supp_fax"]);
                        l_obj.supp_cnic = SafeConvert.ToString(row["supp_cnic"]);
                        l_obj.supp_email = SafeConvert.ToString(row["supp_email"]);
                        l_obj.supp_rem = SafeConvert.ToString(row["supp_rem"]);
                        l_obj.supp_search = SafeConvert.ToString(row["supp_search"]);
                        l_obj.supp_area = SafeConvert.ToString(row["supp_area"]);
                        l_obj.supp_city = SafeConvert.ToString(row["supp_city"]);
                        l_obj.supp_country = SafeConvert.ToString(row["supp_country"]);
                        l_obj.supp_joining_date = SafeConvert.ToDateTime(row["supp_joining_date"]);


                    }

                }
                responseDTO.DTO = l_obj;
                responseDTO.Result = true;

                return responseDTO;
            }
        }
    }
}
