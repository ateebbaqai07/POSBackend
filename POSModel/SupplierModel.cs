using System;
using System.Collections.Generic;
using System.Text;

namespace POSModel
{
    public class SupplierModel
    {
        public decimal supp_code { get; set; }

        public string supp_name { get; set; }

        public string supp_ph_no { get; set; }

        public string supp_mob_no { get; set; }

        public string supp_cmp_name { get; set; }

        public string supp_address1 { get; set; }

        public string supp_address2 { get; set; }

        public string supp_cmp_ph_no { get; set; }

        public string supp_sales_tax { get; set; }

        public string supp_ntn { get; set; }

        public decimal? supp_current_bal { get; set; }

        public int? supp_modify { get; set; }

        public int? supp_active { get; set; }

        public int? master_code { get; set; }

        public string branch_id { get; set; }

        public string supp_terms { get; set; }

        public string supp_type { get; set; }

        public string supp_fax { get; set; }

        public string supp_cnic { get; set; }

        public string supp_email { get; set; }

        public string supp_rem { get; set; }

        public string supp_search { get; set; }

        public string supp_area { get; set; }

        public string supp_city { get; set; }

        public string supp_country { get; set; }

        public DateTime? supp_joining_date { get; set; }

    }
}
