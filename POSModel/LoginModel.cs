using System;
using System.Collections.Generic;
using System.Text;

namespace POSModel
{
    public class LoginModel
    {
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string? EmpCode { get; set; }
        public int? salesman_code { get; set; }
        public int? sale { get; set; }
        public int? sale_modify { get; set; }
        public int? sale_return { get; set; }
        public int? sale_return_modify { get; set; }
        public int? purchase { get; set; }
        public int? purchase_modify { get; set; }
        public int? purchase_return { get; set; }
        public int? purchase_return_modify { get; set; }
        public int? voucher { get; set; }
        public int? bank { get; set; }
        public int? customer { get; set; }
        public int? suplier { get; set; }
        public int? item { get; set; }
        public int? cost { get; set; }
        public int? item_list { get; set; }
        public int? customer_list { get; set; }
        public int? supplier_list { get; set; }
        public int? accounts { get; set; }
        public int? reports { get; set; }
        public int? pay_vouchers { get; set; }
        public int? adjustment { get; set; }
        public int? crm { get; set; }
        public int? jv { get; set; }
        public int? slip { get; set; }
        public int? slip_modify { get; set; }
        public int? pay_vouchers_m { get; set; }
        public int? voucher_m { get; set; }
        public int? quotation { get; set; }
        public int? quotation_m { get; set; }
        public int? po { get; set; }
        public int? po_m { get; set; }
        public int? item_modify { get; set; }
        public int? expence { get; set; }
        public int? cost_increase { get; set; }
        public int? cr_date_only { get; set; }
        public int? chng_inv_date { get; set; }
        public int? credit_inv { get; set; }
        public int? qt_verify { get; set; }
        public int? pur_date { get; set; }
        public int? chng_date_cr { get; set; }
        public int? md_cr_cr_day { get; set; }
        public int? chng_date_pay { get; set; }
        public int? md_pay_cr_day { get; set; }
        public int? chng_date_exp { get; set; }
        public int? exp_modify { get; set; }
        public int? chng_date_bcr { get; set; }
        public int? md_bcr_cr_day { get; set; }
        public int? chng_date_bpay { get; set; }
        public int? md_bpay_cr_day { get; set; }
        public int? jv_modify { get; set; }
        public int? rd_slip_verify { get; set; }
        public int? chq_manger { get; set; }
        public int? chq_pay { get; set; }
        public int? chq_rec { get; set; }
        public int? cust_modify { get; set; }
        public int? supp_modify { get; set; }
        public int? view_drawing { get; set; }
        public int? view_exp { get; set; }
        public int? inv_receiving { get; set; }
        public int? bank_rec { get; set; }
        public int? bank_rec_m { get; set; }
        public int? bank_pay { get; set; }
        public int? bank_pay_m { get; set; }
        public int? view_other_branches { get; set; }
        public int? fund_transfer { get; set; }
        public int? fund_transfer_verify { get; set; }
        public int? emp_grp { get; set; }

        public string? company_name { get; set; }

        public string? company_address { get; set; }

        public string? dealin { get; set; }

        public string? contacts { get; set; }
    }
}
