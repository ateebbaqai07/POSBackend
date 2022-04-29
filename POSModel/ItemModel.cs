using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSModel
{
    public class ItemModel
    {
        public decimal product_code { get; set; }

        public string product_desc { get; set; }

        public decimal? cost { get; set; } = 0;

        public decimal? retail { get; set; } = 0;

        public decimal? avg_cost { get; set; } = 0;

        public decimal? qty_inhand { get; set; } = 0;

        public int? case_qty { get; set; } = 0;

        public int? category_code { get; set; }

        public string? category_name { get; set; }

        public string? group_name { get; set; }

        public string po_type { get; set; }

        public decimal? sale_tax { get; set; } = 0;

        public int? min_level { get; set; }

        public int? max_level { get; set; }

        public int? bin_location_code { get; set; }

        public string bin_location { get; set; }

        public int? item_disc { get; set; } = 0;

        public string branch_id { get; set; }

        public DateTime? joining_date { get; set; }

        public int? brand_code { get; set; }

        public int? sub_cate_code { get; set; }

        public string sub_category { get; set; }

        public int? uom_code { get; set; }

        public string uom { get; set; }

        public string design_model { get; set; }

        public int? active { get; set; }

        public string make { get; set; }

        public string barcode { get; set; }

        public int? group_code { get; set; }

        public int? last_sale_rate { get; set; }

        public int? last_sale_qty { get; set; }

        public DateTime? last_sale_date { get; set; }

        public int? last_pur_rate { get; set; }

        public int? last_pur_qty { get; set; }

        public DateTime? last_pur_date { get; set; }

        public int? qty_inhand000 { get; set; }

        public int? qty_inhand001 { get; set; }

        public int? qty_inhand002 { get; set; }

        public int? qty_inhand003 { get; set; }

        public int? qty_inhand004 { get; set; }

        public int? qty_inahnd005 { get; set; }

        public int? qty_inhand006 { get; set; }

        public int? qty_inahnd007 { get; set; }

        public int? qty_inhand008 { get; set; }

        public int? qty_inhand009 { get; set; }

        public int? price_level1 { get; set; }

        public int? price_level2 { get; set; }

        public int? price_level3 { get; set; }

        public int? price_level4 { get; set; }

        public int? price_level5 { get; set; }

        public string tax_code { get; set; }

        public int? retail_min { get; set; }

        public int? retail_max { get; set; }

        public string urdu_desc { get; set; }

        public int? type_print { get; set; }

        public string item_brand { get; set; }

        public IFormFile image { get; set; }
        public byte[]? picture { get; set; }

    }


    public class ItemBinLocationModel
    {
        public decimal bin_id { get; set; }
        public string bin_name { get; set; }
        public string branch_id { get; set; }
    }


    public class ItemCategoryModel
    {
        public decimal category_code { get; set; }
        public string category_name { get; set; }
        public string branch_id { get; set; }
    }

    public class ItemSubCategoryModel
    {
        public decimal sub_cate_code { get; set; }
        public string sub_cate_name { get; set; }
        public string branch_id { get; set; }
    }

    public class ItemUOMModel
    {
        public decimal uom_code { get; set; }
        public string uom_name { get; set; }
        public string branch_id { get; set; }
    }

    public class ItemGroupModel
    {
        public decimal group_code { get; set; }
        public string group_name { get; set; }
        public string branch_id { get; set; }
    }
    
    public class  QuantityModel
    {

        public decimal voucher_no { get; set; }

        public decimal voucher_type { get; set; }

        public decimal? master_code { get; set; }

        public decimal product_code { get; set; }

        public DateTime? open_date { get; set; }

        public DateTime? open_datetime { get; set; }

        public decimal? open_qty { get; set; }

        public string branch_id { get; set; }

        public string particulars { get; set; }

        public string product_name { get; set; }

        public decimal? open_cost { get; set; }

    }

}
