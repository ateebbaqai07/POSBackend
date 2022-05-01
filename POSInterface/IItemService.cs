using Microsoft.AspNetCore.Http;
using POSModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace POSInterface
{
    public interface IItemService
    {
       public ResponseDTO<string> updateBinLocation(ItemBinLocationModel bin);

        public ResponseDTO<List<ItemBinLocationModel>> getBinLocations();

        public ResponseDTO<string> updateCategory(ItemCategoryModel bin);
        public ResponseDTO<List<ItemCategoryModel>> GetCategories();


        public ResponseDTO<string> updateSubCategory(ItemSubCategoryModel bin);
        public ResponseDTO<List<ItemSubCategoryModel>> GetSubCategories();


        public ResponseDTO<string> updateUOM(ItemUOMModel bin);
        public ResponseDTO<List<ItemUOMModel>> GetUOMList();


        public ResponseDTO<string> updateGroup(ItemGroupModel bin);
        public ResponseDTO<List<ItemGroupModel>> GetGroups();

        public ResponseDTO<string> updateItem(ItemModel bin);
        public ResponseDTO<List<ItemModel>> GetItems();

        public ResponseDTO<QuantityModel> GetItemQuantity(decimal voucherNo);
        public ResponseDTO<string> updateQuantity(QuantityModel bin);

        public ResponseDTO<string> addItemVendor(ItemVendorModel bin);

        public ResponseDTO<string> deleteItemVendor(ItemVendorModel bin);

        public ResponseDTO<List<ItemVendorModel>> GetItemVendors();




    }
}
