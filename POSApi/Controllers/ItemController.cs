using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POSModel;
using POSServiceProvider;
using System.Collections.Generic;

namespace POSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {


        [HttpPost]
        [Route("[action]")]
        public ResponseDTO<string> UpdateBinLocation(ItemBinLocationModel bin)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().updateBinLocation(bin);

        }

        [HttpGet]
        [Route("[action]")]
        public ResponseDTO<List<ItemBinLocationModel>> GetBinLocations()
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().getBinLocations();

        }


        [HttpPost]
        [Route("[action]")]
        public ResponseDTO<string> UpdateCategory(ItemCategoryModel bin)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().updateCategory(bin);

        }

        [HttpGet]
        [Route("[action]")]
        public ResponseDTO<List<ItemCategoryModel>> GetCategories()
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().GetCategories();

        }


        [HttpPost]
        [Route("[action]")]
        public ResponseDTO<string> UpdateSubCategory(ItemSubCategoryModel bin)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().updateSubCategory(bin);

        }

        [HttpGet]
        [Route("[action]")]
        public ResponseDTO<List<ItemSubCategoryModel>> GetSubCategories()
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().GetSubCategories();

        }

        [HttpPost]
        [Route("[action]")]
        public ResponseDTO<string> UpdateUOM(ItemUOMModel bin)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().updateUOM(bin);

        }

        [HttpGet]
        [Route("[action]")]
        public ResponseDTO<List<ItemUOMModel>> GetUOMList()
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().GetUOMList();

        }


        [HttpPost]
        [Route("[action]")]
        public ResponseDTO<string> UpdateGroup(ItemGroupModel bin)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().updateGroup(bin);

        }

        [HttpGet]
        [Route("[action]")]
        public ResponseDTO<List<ItemGroupModel>> GetGroups()
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().GetGroups();

        }


        [HttpPost]
        [Route("[action]")]
        public ResponseDTO<string> UpdateQuantity(QuantityModel bin)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().updateQuantity(bin);

        }

        [HttpGet]
        [Route("[action]")]
        public ResponseDTO<QuantityModel> GetItemQuantity(decimal voucharNo)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().GetItemQuantity(voucharNo);

        }

        [HttpPost]
        [Route("[action]")]
        public ResponseDTO<string> addItemVendor(ItemVendorModel bin)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().addItemVendor(bin);

        }


        [HttpPost]
        [Route("[action]")]
        public ResponseDTO<string> deleteItemVendor(ItemVendorModel bin)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().deleteItemVendor(bin);

        }

        [HttpGet]
        [Route("[action]")]
        public ResponseDTO<List<ItemVendorModel>> GetItemVendors()
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().GetItemVendors();

        }


        [HttpPost] 
        public ResponseDTO<string> Post([FromForm] ItemModel bin)
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().updateItem(bin);

        }

        [HttpGet] 
        public ResponseDTO<List<ItemModel>> Get()
        {
            ServiceProvider sp = new ServiceProvider();
            return sp.GetItemService().GetItems();

        }
    }
}
