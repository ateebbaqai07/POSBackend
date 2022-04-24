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
