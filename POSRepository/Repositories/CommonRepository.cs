using POSModel;
using POSRepository.Common;
using POSRepository.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Tracer;

namespace POSRepository.Repositories
{
    public class CommonRepository : ICommonRepository
    {
        public ResponseDTO<LoginModel> GetLogiUserDetail(string loginID,string Password)
        {
            using (FuncTrace trace = new FuncTrace("CommonRepository", "GetAgentDetailByAgentID"))
            {
                ResponseDTO<LoginModel> responseDTO = new ResponseDTO<LoginModel>();

                //StringBuilder cmd = new StringBuilder();
                List<Parameter> _param = new List<Parameter>();

                ////Set Query
                //cmd.Append(@"select login_name,password,login_info.emp_code from login_info,tblrights where login_info.emp_code = tblrights.salesman_code
                //and login_info.login_name = @login_name and
                //login_info.password = @password");

                //Set Param
                _param.Add(new Parameter { ParameterName = "@login_name", Value = loginID });

                _param.Add(new Parameter { ParameterName = "@password", Value = Password });

                

                DataSet ds = new ClsExecute().GetDataSet("SP_GET_LOGIN", CommandType.StoredProcedure, _param);

                LoginModel l_field = new LoginModel();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        l_field.LoginName = SafeConvert.ToString(row["login_name"]);
                        l_field.Password = SafeConvert.ToString(row["password"]);
                        l_field.EmpCode = SafeConvert.ToString(row["emp_code"]);
                        l_field.salesman_code = SafeConvert.ToInt32(row["salesman_code"]);
                        l_field.sale = SafeConvert.ToInt32(row["sale"]);
                        l_field.sale_modify = SafeConvert.ToInt32(row["sale_modify"]);
                        l_field.sale_return = SafeConvert.ToInt32(row["sale_return"]);
                        l_field.sale_return_modify = SafeConvert.ToInt32(row["sale_return_modify"]);
                        l_field.purchase = SafeConvert.ToInt32(row["purchase"]);
                        l_field.purchase_modify = SafeConvert.ToInt32(row["purchase_modify"]);
                        l_field.purchase_return = SafeConvert.ToInt32(row["purchase_return"]);
                        l_field.purchase_return_modify = SafeConvert.ToInt32(row["purchase_return_modify"]);
                        l_field.voucher = SafeConvert.ToInt32(row["voucher"]);
                        l_field.bank = SafeConvert.ToInt32(row["bank"]);
                        l_field.customer = SafeConvert.ToInt32(row["customer"]);
                        l_field.suplier = SafeConvert.ToInt32(row["suplier"]);
                        l_field.item = SafeConvert.ToInt32(row["item"]);
                        l_field.cost = SafeConvert.ToInt32(row["cost"]);
                        l_field.item_list = SafeConvert.ToInt32(row["item_list"]);
                        l_field.customer_list = SafeConvert.ToInt32(row["customer_list"]);
                        l_field.supplier_list = SafeConvert.ToInt32(row["supplier_list"]);
                        l_field.accounts = SafeConvert.ToInt32(row["accounts"]);
                        l_field.reports = SafeConvert.ToInt32(row["reports"]);
                        l_field.pay_vouchers = SafeConvert.ToInt32(row["pay_vouchers"]);
                        l_field.adjustment = SafeConvert.ToInt32(row["adjustment"]);
                        l_field.crm = SafeConvert.ToInt32(row["crm"]);
                        l_field.jv = SafeConvert.ToInt32(row["jv"]);
                        l_field.slip = SafeConvert.ToInt32(row["slip"]);
                        l_field.slip_modify = SafeConvert.ToInt32(row["slip_modify"]);
                        l_field.pay_vouchers_m = SafeConvert.ToInt32(row["pay_vouchers_m"]);
                        l_field.voucher_m = SafeConvert.ToInt32(row["voucher_m"]);
                        l_field.quotation = SafeConvert.ToInt32(row["quotation"]);
                        l_field.quotation_m = SafeConvert.ToInt32(row["quotation_m"]);
                        l_field.po = SafeConvert.ToInt32(row["po"]);
                        l_field.po_m = SafeConvert.ToInt32(row["po_m"]);
                        l_field.item_modify = SafeConvert.ToInt32(row["item_modify"]);
                        l_field.expence = SafeConvert.ToInt32(row["expence"]);
                        l_field.cost_increase = SafeConvert.ToInt32(row["cost_increase"]);
                        l_field.cr_date_only = SafeConvert.ToInt32(row["cr_date_only"]);
                        l_field.chng_inv_date = SafeConvert.ToInt32(row["chng_inv_date"]);
                        l_field.credit_inv = SafeConvert.ToInt32(row["credit_inv"]);
                        l_field.qt_verify = SafeConvert.ToInt32(row["qt_verify"]);
                        l_field.pur_date = SafeConvert.ToInt32(row["pur_date"]);
                        l_field.chng_date_cr = SafeConvert.ToInt32(row["chng_date_cr"]);
                        l_field.md_cr_cr_day = SafeConvert.ToInt32(row["md_cr_cr_day"]);
                        l_field.chng_date_pay = SafeConvert.ToInt32(row["chng_date_pay"]);
                        l_field.md_pay_cr_day = SafeConvert.ToInt32(row["md_pay_cr_day"]);
                        l_field.chng_date_exp = SafeConvert.ToInt32(row["chng_date_exp"]);
                        l_field.exp_modify = SafeConvert.ToInt32(row["exp_modify"]);
                        l_field.chng_date_bcr = SafeConvert.ToInt32(row["chng_date_bcr"]);
                        l_field.md_bcr_cr_day = SafeConvert.ToInt32(row["md_bcr_cr_day"]);
                        l_field.chng_date_bpay = SafeConvert.ToInt32(row["chng_date_bpay"]);
                        l_field.md_bpay_cr_day = SafeConvert.ToInt32(row["md_bpay_cr_day"]);
                        l_field.jv_modify = SafeConvert.ToInt32(row["jv_modify"]);
                        l_field.rd_slip_verify = SafeConvert.ToInt32(row["rd_slip_verify"]);
                        l_field.chq_manger = SafeConvert.ToInt32(row["chq_manger"]);
                        l_field.chq_pay = SafeConvert.ToInt32(row["chq_pay"]);
                        l_field.chq_rec = SafeConvert.ToInt32(row["chq_rec"]);
                        l_field.cust_modify = SafeConvert.ToInt32(row["cust_modify"]);
                        l_field.supp_modify = SafeConvert.ToInt32(row["supp_modify"]);
                        l_field.view_drawing = SafeConvert.ToInt32(row["supp_modify"]);
                        l_field.view_exp = SafeConvert.ToInt32(row["view_exp"]);
                        l_field.inv_receiving = SafeConvert.ToInt32(row["inv_receiving"]);
                        l_field.bank_rec = SafeConvert.ToInt32(row["bank_rec"]);
                        l_field.bank_rec_m = SafeConvert.ToInt32(row["bank_rec_m"]);
                        l_field.bank_pay = SafeConvert.ToInt32(row["bank_pay"]);
                        l_field.bank_pay_m = SafeConvert.ToInt32(row["bank_pay_m"]);
                        l_field.view_other_branches = SafeConvert.ToInt32(row["view_other_branches"]);
                        l_field.fund_transfer = SafeConvert.ToInt32(row["fund_transfer"]);
                        l_field.fund_transfer_verify = SafeConvert.ToInt32(row["fund_transfer_verify"]);
                        l_field.emp_grp = SafeConvert.ToInt32(row["emp_grp"]);

                        l_field.company_name = SafeConvert.ToString(row["company_name"]);
                        l_field.company_address = SafeConvert.ToString(row["company_address"]);
                        l_field.contacts = SafeConvert.ToString(row["contacts"]);
                        l_field.dealin = SafeConvert.ToString(row["dealin"]); 

                    }
                    responseDTO.DTO = l_field;
                }
                responseDTO.Result = true;

                return responseDTO;
            }
        }
    }
}
