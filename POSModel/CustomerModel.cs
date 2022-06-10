using System;
using System.Collections.Generic;
using System.Text;

namespace POSModel
{
    public class CustomerModel
    {
        public decimal cust_code { get; set; }

        public string cust_name { get; set; }

        public string cust_ph_no { get; set; }

        public string cust_mob_no { get; set; }

        public string cust_address1 { get; set; }

        public string cust_address2 { get; set; }

        public int? cust_modify { get; set; }

        public int? master_code { get; set; }

        public int? cust_active { get; set; }

        public decimal? cust_current_bal { get; set; }

        public string branch_id { get; set; }

        public string cust_email { get; set; }

        public string cust_cnic { get; set; }

        public string cust_area { get; set; }

        public string cust_city { get; set; }

        public string cust_country { get; set; }

        public decimal? salesman_code { get; set; }

        public string cust_type { get; set; }

        public string cust_terms { get; set; }

        public decimal? cust_disc_per { get; set; }

        public int? price_level { get; set; }

        public string cust_cmp_name { get; set; }

        public string cust_ntn_no { get; set; }

        public string cust_sales_tax_reg { get; set; }

        public string cust_fax { get; set; }

        public decimal? cust_credit_limit { get; set; }

        public decimal? cust_credit_days { get; set; }

        public DateTime? cust_joining_date { get; set; }

        public string remarks { get; set; }

        public string search_code { get; set; }

        public string cmp_contact { get; set; }

        public decimal? target { get; set; }

        public decimal? commission { get; set; }

        public DateTime? target_from { get; set; }

        public DateTime? target_to { get; set; }

        public int? last_inv_type { get; set; }

        public int? cust_dng_type { get; set; }

    }

    public class BusinessTypeModel
    {
        public decimal type_code { get; set; }

        public string type_name { get; set; }

    }

    public class CityModel
    {
        public decimal city_code { get; set; }

        public string city_name { get; set; }

        public string branch_id { get; set; }

    }

    public class AreaModel
    {
        public decimal area_code { get; set; }

        public string area_name { get; set; }

        public string branch_id { get; set; }

    }


    public class CountryModel
    {
        public decimal country_code { get; set; }

        public string country_name { get; set; }

        public string branch_id { get; set; }

    }

    public class EmployeeModel
    {
        public decimal emp_code { get; set; }

        public string emp_name { get; set; }

        public string last_name { get; set; }

        public DateTime? dob { get; set; }

        public string ph_no { get; set; }

        public string mob_no { get; set; }

        public string cnic { get; set; }

        public string address { get; set; }

        public DateTime? doj { get; set; }

        public string branch_id { get; set; }

        public string designation { get; set; }

        public decimal? target { get; set; }

        public DateTime? target_from { get; set; }

        public DateTime? taget_to { get; set; }

        public decimal? commission { get; set; }

    }

    public class BranchInfoModel
    {
        public string branch_code { get; set; }

        public string branch_name { get; set; }

        public string branch_address { get; set; }

        public string branch_type { get; set; }

        public string branch_location { get; set; }

        public decimal? system_code { get; set; }

    }


    public class OpeningBalanceModel
    {
        public decimal voucher_no { get; set; }

        public decimal voucher_type { get; set; }

        public char openingType { get; set; }

        public decimal account_code { get; set; }

        public string account_name { get; set; }

        public string branch_id { get; set; }

        public decimal? amount { get; set; }

        public DateTime? open_date { get; set; }

        public DateTime open_datetime { get; set; }

        public decimal? master_code { get; set; }

        public string particulars { get; set; }

    }

}
