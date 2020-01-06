﻿using Bll.Abstract;
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

        public PurchaseHistoryBll(string nickname)
        {
            
            this.nickname = nickname;
            user_id= FactorySingleton.GetDal().Dal.User().GetByFieldName("nickname", nickname)[0].ID.Value;
            HistoryList = new List<PurchaseHistoryDto>();
           
            ClearSortAndFilters();
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
