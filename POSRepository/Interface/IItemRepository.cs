using POSModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSRepository.Interface
{
    public interface IItemRepository
    {
        public ResponseDTO<string> updateBinLocation(ItemBinLocationModel bin);
        public ResponseDTO<List<ItemBinLocationModel>> GetBinLocations();


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
    }
}
