using Microsoft.AspNetCore.Http;
using POSInterface;
using POSModel;
using POSRepository;
using POSRepository.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Tracer;

namespace POSLibrary.Services
{
    public class ItemServices : IItemService
    {
       public ResponseDTO<string> updateBinLocation(ItemBinLocationModel bin)
        {
            using (FuncTrace trace = new FuncTrace("ItemServices", "ItemBinLocationModel"))
            {
                ResponseDTO<string> respDTO = new ResponseDTO<string>();
                try
                {
                    IItemRepository repo = new RepositoryProvider().GetItemRepository();

                    respDTO = repo.updateBinLocation(bin);

                    if (respDTO.ResponseCode == "9000")
                    { 
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Insert or Update Failed" });
                    }
                    else
                    { 
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                        respDTO.Result = true;
                    }
                }
                catch (Exception ex)
                {
                    respDTO.ResponseCode = "-1";
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "ItemServices" + "/ItemBinLocationModel" + ex.Message });
                }
                return respDTO;
            }
        }

        public ResponseDTO<List<ItemBinLocationModel>> getBinLocations()
        {
            using (FuncTrace trace = new FuncTrace("ItemServices", "getBinLocations"))
            {
                ResponseDTO<List<ItemBinLocationModel>> respDTO = new ResponseDTO<List<ItemBinLocationModel>>();
                try
                {
                    IItemRepository repo = new RepositoryProvider().GetItemRepository();

                    respDTO = repo.GetBinLocations();

                    if (respDTO.DTO.Count == 0)
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "No Record Found" });
                    }
                    else
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                        respDTO.Result = true;
                    }
                }
                catch (Exception ex)
                {
                    respDTO.ResponseCode = "-1";
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "ItemServices" + "/getBinLocations" + ex.Message });
                }
                return respDTO;
            }
        }

        public ResponseDTO<string> updateCategory(ItemCategoryModel bin)
        {
            using (FuncTrace trace = new FuncTrace("ItemServices", "updateCategory"))
            {
                ResponseDTO<string> respDTO = new ResponseDTO<string>();
                try
                {
                    IItemRepository repo = new RepositoryProvider().GetItemRepository();

                    respDTO = repo.updateCategory(bin);

                    if (respDTO.ResponseCode == "9000")
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Insert or Update Failed" });
                    }
                    else
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                        respDTO.Result = true;
                    }
                }
                catch (Exception ex)
                {
                    respDTO.ResponseCode = "-1";
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "ItemServices" + "/updateCategory" + ex.Message });
                }
                return respDTO;
            }
        }

        public ResponseDTO<List<ItemCategoryModel>> GetCategories()
        {
            using (FuncTrace trace = new FuncTrace("ItemServices", "GetCategories"))
            {
                ResponseDTO<List<ItemCategoryModel>> respDTO = new ResponseDTO<List<ItemCategoryModel>>();
                try
                {
                    IItemRepository repo = new RepositoryProvider().GetItemRepository();

                    respDTO = repo.GetCategories();

                    if (respDTO.DTO.Count == 0)
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "No Record Found" });
                    }
                    else
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                        respDTO.Result = true;
                    }
                }
                catch (Exception ex)
                {
                    respDTO.ResponseCode = "-1";
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "ItemServices" + "/GetCategories" + ex.Message });
                }
                return respDTO;
            }
        }


        public ResponseDTO<string> updateSubCategory(ItemSubCategoryModel bin)
        {
            using (FuncTrace trace = new FuncTrace("ItemServices", "updateSubCategory"))
            {
                ResponseDTO<string> respDTO = new ResponseDTO<string>();
                try
                {
                    IItemRepository repo = new RepositoryProvider().GetItemRepository();

                    respDTO = repo.updateSubCategory(bin);

                    if (respDTO.ResponseCode == "9000")
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Insert or Update Failed" });
                    }
                    else
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                        respDTO.Result = true;
                    }
                }
                catch (Exception ex)
                {
                    respDTO.ResponseCode = "-1";
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "ItemServices" + "/updateSubCategory" + ex.Message });
                }
                return respDTO;
            }
        }

        public ResponseDTO<List<ItemSubCategoryModel>> GetSubCategories()
        {
            using (FuncTrace trace = new FuncTrace("ItemServices", "GetSubCategories"))
            {
                ResponseDTO<List<ItemSubCategoryModel>> respDTO = new ResponseDTO<List<ItemSubCategoryModel>>();
                try
                {
                    IItemRepository repo = new RepositoryProvider().GetItemRepository();

                    respDTO = repo.GetSubCategories();

                    if (respDTO.DTO.Count == 0)
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "No Record Found" });
                    }
                    else
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                        respDTO.Result = true;
                    }
                }
                catch (Exception ex)
                {
                    respDTO.ResponseCode = "-1";
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "ItemServices" + "/GetSubCategories" + ex.Message });
                }
                return respDTO;
            }
        }

        public ResponseDTO<string> updateUOM(ItemUOMModel bin)
        {
            using (FuncTrace trace = new FuncTrace("ItemServices", "updateUOM"))
            {
                ResponseDTO<string> respDTO = new ResponseDTO<string>();
                try
                {
                    IItemRepository repo = new RepositoryProvider().GetItemRepository();

                    respDTO = repo.updateUOM(bin);

                    if (respDTO.ResponseCode == "9000")
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Insert or Update Failed" });
                    }
                    else
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                        respDTO.Result = true;
                    }
                }
                catch (Exception ex)
                {
                    respDTO.ResponseCode = "-1";
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "ItemServices" + "/updateUOM" + ex.Message });
                }
                return respDTO;
            }
        }

        public ResponseDTO<List<ItemUOMModel>> GetUOMList()
        {
            using (FuncTrace trace = new FuncTrace("ItemServices", "GetUOMList"))
            {
                ResponseDTO<List<ItemUOMModel>> respDTO = new ResponseDTO<List<ItemUOMModel>>();
                try
                {
                    IItemRepository repo = new RepositoryProvider().GetItemRepository();

                    respDTO = repo.GetUOMList();

                    if (respDTO.DTO.Count == 0)
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "No Record Found" });
                    }
                    else
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                        respDTO.Result = true;
                    }
                }
                catch (Exception ex)
                {
                    respDTO.ResponseCode = "-1";
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "ItemServices" + "/GetUOMList" + ex.Message });
                }
                return respDTO;
            }
        }


        public ResponseDTO<string> updateGroup(ItemGroupModel bin)
        {
            using (FuncTrace trace = new FuncTrace("ItemServices", "updateGroup"))
            {
                ResponseDTO<string> respDTO = new ResponseDTO<string>();
                try
                {
                    IItemRepository repo = new RepositoryProvider().GetItemRepository();

                    respDTO = repo.updateGroup(bin);

                    if (respDTO.ResponseCode == "9000")
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Insert or Update Failed" });
                    }
                    else
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                        respDTO.Result = true;
                    }
                }
                catch (Exception ex)
                {
                    respDTO.ResponseCode = "-1";
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "ItemServices" + "/updateGroup" + ex.Message });
                }
                return respDTO;
            }
        }

        public ResponseDTO<List<ItemGroupModel>> GetGroups()
        {
            using (FuncTrace trace = new FuncTrace("ItemServices", "GetGroups"))
            {
                ResponseDTO<List<ItemGroupModel>> respDTO = new ResponseDTO<List<ItemGroupModel>>();
                try
                {
                    IItemRepository repo = new RepositoryProvider().GetItemRepository();

                    respDTO = repo.GetGroups();

                    if (respDTO.DTO.Count == 0)
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "No Record Found" });
                    }
                    else
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                        respDTO.Result = true;
                    }
                }
                catch (Exception ex)
                {
                    respDTO.ResponseCode = "-1";
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "ItemServices" + "/GetGroups" + ex.Message });
                }
                return respDTO;
            }
        }

        public ResponseDTO<string> updateItem(ItemModel bin)
        {
            using (FuncTrace trace = new FuncTrace("ItemServices", "updateItem"))
            {
                ResponseDTO<string> respDTO = new ResponseDTO<string>();
                try
                {
                    IItemRepository repo = new RepositoryProvider().GetItemRepository();
                    bin.picture = fileToByteArray(bin.image);
                    respDTO = repo.updateItem(bin);

                    if (respDTO.ResponseCode == "9000")
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Insert or Update Failed" });
                    }
                    else
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                        respDTO.Result = true;
                    }
                }
                catch (Exception ex)
                {
                    respDTO.ResponseCode = "-1";
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "ItemServices" + "/updateItem" + ex.Message });
                }
                return respDTO;
            }
        }

        public ResponseDTO<List<ItemModel>> GetItems()
        {
            using (FuncTrace trace = new FuncTrace("ItemServices", "GetItems"))
            {
                ResponseDTO<List<ItemModel>> respDTO = new ResponseDTO<List<ItemModel>>();
                try
                {
                    IItemRepository repo = new RepositoryProvider().GetItemRepository();

                    respDTO = repo.GetItems();

                    if (respDTO.DTO.Count == 0)
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "No Record Found" });
                    }
                    else
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                        respDTO.Result = true;
                    }
                }
                catch (Exception ex)
                {
                    respDTO.ResponseCode = "-1";
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "ItemServices" + "/GetItems" + ex.Message });
                }
                return respDTO;
            }
        }


        public ResponseDTO<string> updateQuantity(QuantityModel bin)
        {
            using (FuncTrace trace = new FuncTrace("ItemServices", "updateQuantity"))
            {
                ResponseDTO<string> respDTO = new ResponseDTO<string>();
                try
                {
                    IItemRepository repo = new RepositoryProvider().GetItemRepository();
                    
                    respDTO = repo.updateQuantity(bin);

                    if (respDTO.ResponseCode == "9000")
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Insert or Update Failed" });
                    }
                    else
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                        respDTO.Result = true;
                    }
                }
                catch (Exception ex)
                {
                    respDTO.ResponseCode = "-1";
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "ItemServices" + "/updateQuantity" + ex.Message });
                }
                return respDTO;
            }
        }

        public ResponseDTO<QuantityModel> GetItemQuantity(decimal voucherNo)
        {
            using (FuncTrace trace = new FuncTrace("ItemServices", "GetItemQuantity"))
            {
                ResponseDTO<QuantityModel> respDTO = new ResponseDTO<QuantityModel>();
                try
                {
                    IItemRepository repo = new RepositoryProvider().GetItemRepository();

                    respDTO = repo.GetQuantity(voucherNo);

                    if (respDTO.DTO == null)
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "No Record Found" });
                    }
                    else
                    {
                        respDTO.ErrorMessages.Add(new ErrorMessage { Message = "Success" });
                        respDTO.Result = true;
                    }
                }
                catch (Exception ex)
                {
                    respDTO.ResponseCode = "-1";
                    respDTO.ErrorMessages.Add(new ErrorMessage { Message = "ItemServices" + "/GetItemQuantity" + ex.Message });
                }
                return respDTO;
            }
        }

        private byte[] fileToByteArray(IFormFile file)
        {
            byte[] fileBytes = null;
            if(file != null)
            if (file.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    fileBytes = ms.ToArray();
                    string s = Convert.ToBase64String(fileBytes);
                    // act on the Base64 data

                }
            }
            return fileBytes;
        }
    }
}
