using Bll.Abstract;
using DalFactory;
using Dto;
using Entity.Concrete;
using System;
using System.Collections.Generic;

namespace Bll.Concrete
{
    public class PurchaseHistoryBll:IPurchaseHistoryBll
    {
        private  List<PurchaseHistoryDto> HistoryList;
        private readonly long user_id;
        private readonly string nickname;
        public string Nickname { get { return nickname; } }

        public PurchaseHistoryBll(string nickname)
        {
            
            this.nickname = nickname;
            user_id= FactorySingleton.GetDal().Dal.User().GetByFieldName("nickname", nickname)[0].ID.Value;
            HistoryList = new List<PurchaseHistoryDto>();
           
            ClearSortAndFilters();
        }

        public int Edit(PurchaseHistoryDto Dto,string productOldName)
        {
            try
            {
                FactorySingleton.GetDal().Dal.Product().UpdateByEntity(new ProductEntity(Dto.Name, Dto.Cost.Value, Dto.Type, Dto.Brand)
                { ID = FactorySingleton.GetDal().Dal.Product().GetByFieldName("name", productOldName)[0].ID.Value });
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int Add(PurchaseHistoryDto Dto)
        {
            try
            {
                FactorySingleton.GetDal().Dal.Product().Insert(new ProductEntity(Dto.Name, Dto.Cost.Value, Dto.Brand, Dto.Brand));
                FactorySingleton.GetDal().Dal.PurchaseHistory().Insert(
                    new PurchaseHistoryEntity(user_id, FactorySingleton.GetDal().Dal.Product().GetByFieldName("name", Dto.Name)[0].ID.Value, DateTime.Now));

                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int Delete(PurchaseHistoryDto Dto)
        {
            try
            {
                int x = FactorySingleton.GetDal().Dal.PurchaseHistory().Delete(new PurchaseHistoryEntity
                    (user_id, FactorySingleton.GetDal().Dal.Product().GetByFieldName("name", Dto.Name)[0].ID.Value, Dto.Date));
                FactorySingleton.GetDal().Dal.Product().DeleteByFieldName("id", FactorySingleton.GetDal().Dal.Product().GetByFieldName("name", Dto.Name)[0].ID.Value);
                return x;
            }
            catch
            {
                return 0;
            }
        }
        //Private
        private List<PurchaseHistoryDto> GetFullList()
        {
            List<PurchaseHistoryDto> FullList = new List<PurchaseHistoryDto>();
            List<PurchaseHistoryEntity> Historylist = (List<PurchaseHistoryEntity>)FactorySingleton.GetDal().Dal.PurchaseHistory().GetByFieldName("id", user_id);
            
            foreach (var el in Historylist)
            {
                ProductEntity Product= FactorySingleton.GetDal().Dal.Product().GetById(el.ProductID.Value);
                FullList.Add(new PurchaseHistoryDto (Product.Name, Product.Cost.Value, Product.Type,  Product.Brand, nickname, el.Date));
            }
            return FullList;
        }

        //Public
        public  int GetFilteredByNameList(string purchaseName)
        {
            List<PurchaseHistoryDto> Historylist = new List<PurchaseHistoryDto>();
            foreach (var el in HistoryList)
            {
                if(el.Name== purchaseName)
                { Historylist.Add(new PurchaseHistoryDto(el.Name, el.Cost.Value, el.Type, el.Brand, nickname, el.Date)); }
               
            }
            HistoryList.Clear();
            foreach (var el in Historylist)
            {
                 HistoryList.Add(new PurchaseHistoryDto(el.Name, el.Cost.Value, el.Type, el.Brand, nickname, el.Date)); 
            }
            return HistoryList.Count;
        }
        public int GetFilteredByCostList(double costStart,double costEnd)
        {
            List<PurchaseHistoryDto> Historylist = new List<PurchaseHistoryDto>();
            foreach (var el in HistoryList)
            {
                if (el.Cost >= costStart && el.Cost <= costEnd)
                { Historylist.Add(new PurchaseHistoryDto(el.Name, el.Cost.Value, el.Type, el.Brand, nickname, el.Date)); }

            }
            HistoryList.Clear();
            foreach (var el in Historylist)
            {
                HistoryList.Add(new PurchaseHistoryDto(el.Name, el.Cost.Value, el.Type, el.Brand, nickname, el.Date));
            }
            return HistoryList.Count;
        }
        public int GetFilteredByTypeList(string type)
        {
            List<PurchaseHistoryDto> Historylist = new List<PurchaseHistoryDto>();
            foreach (var el in HistoryList)
            {
                if (el.Type == type)
                { Historylist.Add(new PurchaseHistoryDto(el.Name, el.Cost.Value, el.Type, el.Brand, nickname, el.Date)); }

            }
            HistoryList.Clear();
            foreach (var el in Historylist)
            {
                HistoryList.Add(new PurchaseHistoryDto(el.Name, el.Cost.Value, el.Type, el.Brand, nickname, el.Date));
            }
            return HistoryList.Count;
        }
        public int GetFilteredByBradList(string brand)
        {
            List<PurchaseHistoryDto> Historylist = new List<PurchaseHistoryDto>();
            foreach (var el in HistoryList)
            {
                if (el.Brand == brand)
                { Historylist.Add(new PurchaseHistoryDto(el.Name, el.Cost.Value, el.Type, el.Brand, nickname, el.Date)); }

            }
            HistoryList.Clear();
            foreach (var el in Historylist)
            {
                HistoryList.Add(new PurchaseHistoryDto(el.Name, el.Cost.Value, el.Type, el.Brand, nickname, el.Date));
            }
            return HistoryList.Count;
        }
        public int ClearSortAndFilters()
        {
           
            HistoryList.Clear();
            foreach (var el in GetFullList())
            {
                HistoryList.Add(el);
            }
            return HistoryList.Count;
        }
        public int SortByName()
        {
            HistoryList.Sort(new PurchaseHistoryComparerByName());
            return HistoryList.Count;
        }
        public int SortByCost()
        {
            HistoryList.Sort(new PurchaseHistoryComparerByCost());
            return HistoryList.Count;
        }
        public int SortByType()
        {
            HistoryList.Sort(new PurchaseHistoryComparerByType());
            return HistoryList.Count;
        }
        public int SortByBrand()
        {
            HistoryList.Sort(new PurchaseHistoryComparerByBrand());
            return HistoryList.Count;
        }
        public int SortByDate()
        {
            HistoryList.Sort(new PurchaseHistoryComparerByDate());
            return HistoryList.Count;
        }

        public List<PurchaseHistoryDto> GetList()
        {
            return HistoryList;
        }

        
    }
}
