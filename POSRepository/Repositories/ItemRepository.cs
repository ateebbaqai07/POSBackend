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
    public class ItemRepository : IItemRepository
    {
        public ResponseDTO<string> updateBinLocation(ItemBinLocationModel bin)
        {
            using (FuncTrace trace = new FuncTrace("ItemRepository", "updateBinLocation"))
            {
                ResponseDTO<string> responseDTO = new ResponseDTO<string>();
                List<Parameter> _param = new List<Parameter>();

                //Set Param
                _param.Add(new Parameter { ParameterName = "@bin_id", Value = bin.bin_id });

                _param.Add(new Parameter { ParameterName = "@bin_name", Value = bin.bin_name });

                _param.Add(new Parameter { ParameterName = "@branch_id", Value = bin.branch_id });
                 

                DataSet ds = new ClsExecute().GetDataSet("sp_update_item_bin_Location", CommandType.StoredProcedure, _param);

                
                if (ds.Tables[0].Rows.Count > 0)
                {
                    responseDTO.ResponseCode = SafeConvert.ToString(ds.Tables[0].Rows[0]["retValue"]);
                     
                } 

                return responseDTO;
            }
        }

        public ResponseDTO<List<ItemBinLocationModel>> GetBinLocations()
        {
            using (FuncTrace trace = new FuncTrace("ItemRepository", "GetBinLocations"))
            {
                ResponseDTO<List<ItemBinLocationModel>> responseDTO = new ResponseDTO<List<ItemBinLocationModel>>();
                List<Parameter> _param = new List<Parameter>();


                DataSet ds = new ClsExecute().GetDataSet("SP_GET_BIN_LOCATIONS", CommandType.StoredProcedure, _param);

                List<ItemBinLocationModel> l_field = new List<ItemBinLocationModel>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                   
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        ItemBinLocationModel l_obj = new ItemBinLocationModel();
                        l_obj.bin_id = SafeConvert.ToInt32(row["bin_code"]);
                        l_obj.bin_name = SafeConvert.ToString(row["bin_name"]);
                        l_obj.branch_id = SafeConvert.ToString(row["branch_id"]);
                        l_field.Add(l_obj);

                    } 
                    
                }
                responseDTO.DTO = l_field;
                responseDTO.Result = true;

                return responseDTO;
            }
        }

        public ResponseDTO<string> updateCategory(ItemCategoryModel bin)
        {
            using (FuncTrace trace = new FuncTrace("ItemRepository", "updateCategory"))
            {
                ResponseDTO<string> responseDTO = new ResponseDTO<string>();
                List<Parameter> _param = new List<Parameter>();

                //Set Param
                _param.Add(new Parameter { ParameterName = "@category_code", Value = bin.category_code });

                _param.Add(new Parameter { ParameterName = "@category_name", Value = bin.category_name });

                _param.Add(new Parameter { ParameterName = "@branch_id", Value = bin.branch_id });


                DataSet ds = new ClsExecute().GetDataSet("sp_update_item_category", CommandType.StoredProcedure, _param);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    responseDTO.ResponseCode = SafeConvert.ToString(ds.Tables[0].Rows[0]["retValue"]);

                }

                return responseDTO;
            }
        }

        public ResponseDTO<List<ItemCategoryModel>> GetCategories()
        {
            using (FuncTrace trace = new FuncTrace("ItemRepository", "GetCategories"))
            {
                ResponseDTO<List<ItemCategoryModel>> responseDTO = new ResponseDTO<List<ItemCategoryModel>>();
                List<Parameter> _param = new List<Parameter>();


                DataSet ds = new ClsExecute().GetDataSet("SP_GET_ITEM_CATEGORIES", CommandType.StoredProcedure, _param);

                List<ItemCategoryModel> l_field = new List<ItemCategoryModel>();
                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        ItemCategoryModel l_obj = new ItemCategoryModel();
                        l_obj.category_code = SafeConvert.ToInt32(row["category_code"]);
                        l_obj.category_name = SafeConvert.ToString(row["category_name"]);
                        l_obj.branch_id = SafeConvert.ToString(row["branch_id"]);
                        l_field.Add(l_obj);

                    }

                }
                responseDTO.DTO = l_field;
                responseDTO.Result = true;

                return responseDTO;
            }
        }


        public ResponseDTO<string> updateSubCategory(ItemSubCategoryModel bin)
        {
            using (FuncTrace trace = new FuncTrace("ItemRepository", "updateSubCategory"))
            {
                ResponseDTO<string> responseDTO = new ResponseDTO<string>();
                List<Parameter> _param = new List<Parameter>();

                //Set Param
                _param.Add(new Parameter { ParameterName = "@id", Value = bin.sub_cate_code });

                _param.Add(new Parameter { ParameterName = "@sub_cate_name", Value = bin.sub_cate_name });

                _param.Add(new Parameter { ParameterName = "@branch_id", Value = bin.branch_id });


                DataSet ds = new ClsExecute().GetDataSet("sp_update_item_sub_category", CommandType.StoredProcedure, _param);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    responseDTO.ResponseCode = SafeConvert.ToString(ds.Tables[0].Rows[0]["retValue"]);

                }

                return responseDTO;
            }
        }

        public ResponseDTO<List<ItemSubCategoryModel>> GetSubCategories()
        {
            using (FuncTrace trace = new FuncTrace("ItemRepository", "GetSubCategories"))
            {
                ResponseDTO<List<ItemSubCategoryModel>> responseDTO = new ResponseDTO<List<ItemSubCategoryModel>>();
                List<Parameter> _param = new List<Parameter>();


                DataSet ds = new ClsExecute().GetDataSet("SP_GET_ITEM_SUBCATEGORIES", CommandType.StoredProcedure, _param);

                List<ItemSubCategoryModel> l_field = new List<ItemSubCategoryModel>();
                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        ItemSubCategoryModel l_obj = new ItemSubCategoryModel();
                        l_obj.sub_cate_code = SafeConvert.ToInt32(row["sub_cate_code"]);
                        l_obj.sub_cate_name = SafeConvert.ToString(row["sub_cate_name"]);
                        l_obj.branch_id = SafeConvert.ToString(row["branch_id"]);
                        l_field.Add(l_obj);

                    }

                }
                responseDTO.DTO = l_field;
                responseDTO.Result = true;

                return responseDTO;
            }
        }


        public ResponseDTO<string> updateUOM(ItemUOMModel bin)
        {
            using (FuncTrace trace = new FuncTrace("ItemRepository", "updateUOM"))
            {
                ResponseDTO<string> responseDTO = new ResponseDTO<string>();
                List<Parameter> _param = new List<Parameter>();

                //Set Param
                _param.Add(new Parameter { ParameterName = "@id", Value = bin.uom_code });

                _param.Add(new Parameter { ParameterName = "@uom_name", Value = bin.uom_name });

                _param.Add(new Parameter { ParameterName = "@branch_id", Value = bin.branch_id });


                DataSet ds = new ClsExecute().GetDataSet("sp_update_item_uom", CommandType.StoredProcedure, _param);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    responseDTO.ResponseCode = SafeConvert.ToString(ds.Tables[0].Rows[0]["retValue"]);

                }

                return responseDTO;
            }
        }

        public ResponseDTO<List<ItemUOMModel>> GetUOMList()
        {
            using (FuncTrace trace = new FuncTrace("ItemRepository", "GetUOMList"))
            {
                ResponseDTO<List<ItemUOMModel>> responseDTO = new ResponseDTO<List<ItemUOMModel>>();
                List<Parameter> _param = new List<Parameter>();


                DataSet ds = new ClsExecute().GetDataSet("SP_GET_ITEM_UOM", CommandType.StoredProcedure, _param);

                List<ItemUOMModel> l_field = new List<ItemUOMModel>();
                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        ItemUOMModel l_obj = new ItemUOMModel();
                        l_obj.uom_code = SafeConvert.ToInt32(row["uom_code"]);
                        l_obj.uom_name = SafeConvert.ToString(row["uom_name"]);
                        l_obj.branch_id = SafeConvert.ToString(row["branch_id"]);
                        l_field.Add(l_obj);

                    }

                }
                responseDTO.DTO = l_field;
                responseDTO.Result = true;

                return responseDTO;
            }
        }

        public ResponseDTO<string> updateGroup(ItemGroupModel bin)
        {
            using (FuncTrace trace = new FuncTrace("ItemRepository", "updateGroup"))
            {
                ResponseDTO<string> responseDTO = new ResponseDTO<string>();
                List<Parameter> _param = new List<Parameter>();

                //Set Param
                _param.Add(new Parameter { ParameterName = "@id", Value = bin.group_code });

                _param.Add(new Parameter { ParameterName = "@group_name", Value = bin.group_name });

                _param.Add(new Parameter { ParameterName = "@branch_id", Value = bin.branch_id });


                DataSet ds = new ClsExecute().GetDataSet("sp_update_item_group", CommandType.StoredProcedure, _param);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    responseDTO.ResponseCode = SafeConvert.ToString(ds.Tables[0].Rows[0]["retValue"]);

                }

                return responseDTO;
            }
        }

        public ResponseDTO<List<ItemGroupModel>> GetGroups()
        {
            using (FuncTrace trace = new FuncTrace("ItemRepository", "GetUOMList"))
            {
                ResponseDTO<List<ItemGroupModel>> responseDTO = new ResponseDTO<List<ItemGroupModel>>();
                List<Parameter> _param = new List<Parameter>();


                DataSet ds = new ClsExecute().GetDataSet("SP_GET_ITEM_GROUP", CommandType.StoredProcedure, _param);

                List<ItemGroupModel> l_field = new List<ItemGroupModel>();
                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        ItemGroupModel l_obj = new ItemGroupModel();
                        l_obj.group_code = SafeConvert.ToInt32(row["group_code"]);
                        l_obj.group_name = SafeConvert.ToString(row["group_name"]);
                        l_obj.branch_id = SafeConvert.ToString(row["branch_id"]);
                        l_field.Add(l_obj);

                    }

                }
                responseDTO.DTO = l_field;
                responseDTO.Result = true;

                return responseDTO;
            }
        }

        public ResponseDTO<string> updateItem(ItemModel bin)
        {
            using (FuncTrace trace = new FuncTrace("ItemRepository", "updateItem"))
            {
                ResponseDTO<string> responseDTO = new ResponseDTO<string>();
                List<Parameter> _param = new List<Parameter>();

                //Set Param

                _param.Add(new Parameter { ParameterName = "@id", Value = bin.product_code, DbType = ParameterDbType.Decimal});
                _param.Add(new Parameter { ParameterName = "@product_desc", Value = bin.product_desc, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@cost", Value = bin.cost, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@retail", Value = bin.retail, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@avg_cost", Value = bin.avg_cost, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@qty_inhand", Value = bin.qty_inhand, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@case_qty", Value = bin.case_qty, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@category_code", Value = bin.category_code, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@po_type", Value = bin.po_type, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@sale_tax", Value = bin.sale_tax, DbType = ParameterDbType.Decimal });
                _param.Add(new Parameter { ParameterName = "@min_level", Value = bin.min_level, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@max_level", Value = bin.max_level, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@bin_location_code", Value = bin.bin_location_code, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@bin_location", Value = bin.bin_location, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@item_disc", Value = bin.item_disc, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@branch_id", Value = bin.branch_id, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@joining_date", Value = bin.joining_date, DbType = ParameterDbType.DateTime });
                _param.Add(new Parameter { ParameterName = "@brand_code", Value = bin.brand_code, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@sub_cate_code", Value = bin.sub_cate_code, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@sub_category", Value = bin.sub_category, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@uom_code", Value = bin.uom_code, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@uom", Value = bin.uom, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@design_model", Value = bin.design_model, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@active", Value = bin.active, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@make", Value = bin.make, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@barcode", Value = bin.barcode, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@group_code", Value = bin.group_code, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@last_sale_rate", Value = bin.last_sale_rate, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@last_sale_qty", Value = bin.last_sale_qty, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@last_sale_date", Value = bin.last_sale_date, DbType = ParameterDbType.DateTime });
                _param.Add(new Parameter { ParameterName = "@last_pur_rate", Value = bin.last_pur_rate, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@last_pur_qty", Value = bin.last_pur_qty, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@last_pur_date", Value = bin.last_pur_date, DbType = ParameterDbType.DateTime });
                _param.Add(new Parameter { ParameterName = "@qty_inhand000", Value = bin.qty_inhand000, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@qty_inhand001", Value = bin.qty_inhand001, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@qty_inhand002", Value = bin.qty_inhand002, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@qty_inhand003", Value = bin.qty_inhand003, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@qty_inhand004", Value = bin.qty_inhand004, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@qty_inahnd005", Value = bin.qty_inahnd005, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@qty_inhand006", Value = bin.qty_inhand006, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@qty_inahnd007", Value = bin.qty_inahnd007, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@qty_inhand008", Value = bin.qty_inhand008, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@qty_inhand009", Value = bin.qty_inhand009, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@price_level1", Value = bin.price_level1, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@price_level2", Value = bin.price_level2, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@price_level3", Value = bin.price_level3, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@price_level4", Value = bin.price_level4, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@price_level5", Value = bin.price_level5, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@tax_code", Value = bin.tax_code, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@retail_min", Value = bin.retail_min, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@retail_max", Value = bin.retail_max, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@urdu_desc", Value = bin.urdu_desc, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@type_print", Value = bin.type_print, DbType = ParameterDbType.Int32 });
                _param.Add(new Parameter { ParameterName = "@item_brand", Value = bin.item_brand, DbType = ParameterDbType.String });
                _param.Add(new Parameter { ParameterName = "@picture", Value = bin.picture, DbType = ParameterDbType.Byte });


                DataSet ds = new ClsExecute().GetDataSet("sp_update_item", CommandType.StoredProcedure, _param);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    responseDTO.ResponseCode = SafeConvert.ToString(ds.Tables[0].Rows[0]["retValue"]);

                }

                return responseDTO;
            }
        }

        public ResponseDTO<List<ItemModel>> GetItems()
        {
            using (FuncTrace trace = new FuncTrace("ItemRepository", "GetItems"))
            {
                ResponseDTO<List<ItemModel>> responseDTO = new ResponseDTO<List<ItemModel>>();
                List<Parameter> _param = new List<Parameter>();
                _param.Add(new Parameter { ParameterName = "@active", Value = 1, DbType = ParameterDbType.Int32 });


                DataSet ds = new ClsExecute().GetDataSet("sp_product_list", CommandType.StoredProcedure, _param);

                List<ItemModel> l_field = new List<ItemModel>();
                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        ItemModel l_obj = new ItemModel();
                        l_obj.product_code = SafeConvert.ToDecimal(row["product_code"]);
                        l_obj.barcode = SafeConvert.ToString(row["barcode"]);
                        l_obj.product_desc = SafeConvert.ToString(row["product_desc"]);
                        l_obj.cost = SafeConvert.ToDecimal(row["cost"]);
                        l_obj.retail = SafeConvert.ToDecimal(row["retail"]);
                        l_obj.avg_cost = SafeConvert.ToDecimal(row["avg_cost"]);
                        l_obj.qty_inhand = SafeConvert.ToDecimal(row["qty_inhand"]);
                        l_obj.case_qty = SafeConvert.ToInt32(row["case_qty"]);
                        l_obj.category_name = SafeConvert.ToString(row["category_name"]);
                        l_obj.po_type = SafeConvert.ToString(row["po_type"]);
                        l_obj.sale_tax = SafeConvert.ToDecimal(row["sale_tax"]);
                        l_obj.min_level = SafeConvert.ToInt32(row["min_level"]);
                        l_obj.max_level = SafeConvert.ToInt32(row["max_level"]);
                        //l_obj.bin_location_code = SafeConvert.ToInt32(row["bin_location_code"]);
                        l_obj.bin_location = SafeConvert.ToString(row["bin_name"]);
                        l_obj.item_disc = SafeConvert.ToInt32(row["item_disc"]);
                        l_obj.branch_id = SafeConvert.ToString(row["branch_id"]);
                        l_obj.joining_date = SafeConvert.ToDateTime(row["joining_date"]);
                        l_obj.brand_code = SafeConvert.ToInt32(row["brand_code"]);
                        //l_obj.sub_cate_code = SafeConvert.ToInt32(row["sub_cate_code"]);
                        l_obj.sub_category = SafeConvert.ToString(row["sub_cate_name"]);
                        //l_obj.uom_code = SafeConvert.ToInt32(row["uom_code"]);
                        l_obj.uom = SafeConvert.ToString(row["uom_name"]);
                        l_obj.design_model = SafeConvert.ToString(row["design_model"]);
                        l_obj.active = SafeConvert.ToInt32(row["active"]);
                        l_obj.make = SafeConvert.ToString(row["make"]); 
                        l_obj.group_name = SafeConvert.ToString(row["group_name"]);
                        l_obj.last_sale_rate = SafeConvert.ToInt32(row["last_sale_rate"]);
                        l_obj.last_sale_qty = SafeConvert.ToInt32(row["last_sale_qty"]);
                        l_obj.last_sale_date = SafeConvert.ToDateTime(row["last_sale_date"]);
                        l_obj.last_pur_rate = SafeConvert.ToInt32(row["last_pur_rate"]);
                        l_obj.last_pur_qty = SafeConvert.ToInt32(row["last_pur_qty"]);
                        l_obj.last_pur_date = SafeConvert.ToDateTime(row["last_pur_date"]);
                        //l_obj.qty_inhand000 = SafeConvert.ToInt32(row["qty_inhand000"]);
                        //l_obj.qty_inhand001 = SafeConvert.ToInt32(row["qty_inhand001"]);
                        //l_obj.qty_inhand002 = SafeConvert.ToInt32(row["qty_inhand002"]);
                        //l_obj.qty_inhand003 = SafeConvert.ToInt32(row["qty_inhand003"]);
                        //l_obj.qty_inhand004 = SafeConvert.ToInt32(row["qty_inhand004"]);
                        //l_obj.qty_inahnd005 = SafeConvert.ToInt32(row["qty_inahnd005"]);
                        //l_obj.qty_inhand006 = SafeConvert.ToInt32(row["qty_inhand006"]);
                        //l_obj.qty_inahnd007 = SafeConvert.ToInt32(row["qty_inahnd007"]);
                        //l_obj.qty_inhand008 = SafeConvert.ToInt32(row["qty_inhand008"]);
                        //l_obj.qty_inhand009 = SafeConvert.ToInt32(row["qty_inhand009"]);
                        l_obj.price_level1 = SafeConvert.ToInt32(row["price_level1"]);
                        l_obj.price_level2 = SafeConvert.ToInt32(row["price_level2"]);
                        l_obj.price_level3 = SafeConvert.ToInt32(row["price_level3"]);
                        l_obj.price_level4 = SafeConvert.ToInt32(row["price_level4"]);
                        l_obj.price_level5 = SafeConvert.ToInt32(row["price_level5"]);
                        l_obj.tax_code = SafeConvert.ToString(row["tax_code"]);
                        l_obj.retail_min = SafeConvert.ToInt32(row["retail_min"]);
                        l_obj.retail_max = SafeConvert.ToInt32(row["retail_max"]);
                        l_obj.urdu_desc = SafeConvert.ToString(row["urdu_desc"]);
                        //l_obj.type_print = SafeConvert.ToInt32(row["type_print"]);
                        l_obj.item_brand = SafeConvert.ToString(row["item_brand"]);
                    
                    l_field.Add(l_obj);

                    }

                }
                responseDTO.DTO = l_field;
                responseDTO.Result = true;

                return responseDTO;
            }
        }
    }
}
