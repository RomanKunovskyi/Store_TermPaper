using Dto;
using System.Collections.Generic;

namespace Bll.Abstract
{
    public interface IPurchaseHistoryBll
    {
        int Add(PurchaseHistoryDto Dto);
        int Delete(PurchaseHistoryDto Dto);
        int Edit(PurchaseHistoryDto Dto,string productOldName);
        int GetFilteredByNameList(string purchaseName);
        int GetFilteredByCostList(double costStart, double costEnd);
        int GetFilteredByTypeList(string type);
        int GetFilteredByBradList(string brand);
        int ClearSortAndFilters();
        int SortByName();
        int SortByCost();
        int SortByType();
        int SortByBrand();
        int SortByDate();
        List<PurchaseHistoryDto> GetList();
    }
    class PurchaseHistoryComparerByName : IComparer<PurchaseHistoryDto>
    {
        public int Compare(PurchaseHistoryDto p1, PurchaseHistoryDto p2) => p1.Name.CompareTo(p2.Name);
    }
    class PurchaseHistoryComparerByCost : IComparer<PurchaseHistoryDto>
    {
        public int Compare(PurchaseHistoryDto p1, PurchaseHistoryDto p2)
        {
            if (p1.Cost > p2.Cost)
                return 1;
            else if (p1.Cost < p2.Cost)
                return -1;
            else
                return 0;
        }
    }
    class PurchaseHistoryComparerByType : IComparer<PurchaseHistoryDto>
    {
        public int Compare(PurchaseHistoryDto p1, PurchaseHistoryDto p2) => p1.Type.CompareTo(p2.Type);
    }
    class PurchaseHistoryComparerByBrand : IComparer<PurchaseHistoryDto>
    {
        public int Compare(PurchaseHistoryDto p1, PurchaseHistoryDto p2) => p1.Brand.CompareTo(p2.Brand);
    }
    class PurchaseHistoryComparerByDate : IComparer<PurchaseHistoryDto>
    {
        public int Compare(PurchaseHistoryDto p1, PurchaseHistoryDto p2) => p1.Date.CompareTo(p2.Date);
    }
}
