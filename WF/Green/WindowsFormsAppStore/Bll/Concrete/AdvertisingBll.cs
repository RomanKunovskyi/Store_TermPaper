using System.Collections.Generic;
using Bll.Abstract;
using DalFactory;
using Dto;
using Entity.Concrete;

namespace Bll.Concrete
{
    public class AdvertisingBll : IAdvertisingBll
    {
        public List<AdvertisingDto> GetAdvertising()
        {
            int num = 0;
            List<AdvertisingDto> Advertising = new List<AdvertisingDto>();
            List<AdvertisingEntity> FulList = (List < AdvertisingEntity > )FactorySingleton.GetDal().Dal.Advertising().GetAll();
            if(FulList.Count!=0)
            {
                foreach (var el in FulList)
                {
                    Advertising.Add(new AdvertisingDto(el.Purchase,el.Cost,el.Type,el.Info,el.Picture));
                    num += 1;
                    if (num == 3)
                    {
                        break;
                    }
                }
                while (num < 3)
                {
                    Advertising.Add(Advertising[0]);
                    num += 1;
                }
                return Advertising;
            }
            else
            {
                return Advertising;
            }
        }

        public List<AdvertisingDto> GetAdvertising(List<string> tags)
        {
            List<AdvertisingDto> Advertising = new List<AdvertisingDto>();
            int num = 0;
            foreach (string tag in tags)
            {
                List<AdvertisingEntity> FulList = (List<AdvertisingEntity>)FactorySingleton.GetDal().Dal.Advertising().GetByFieldName("type", tag);
                if (FulList.Count != 0 && num < 3)
                {
                    foreach (var el in FulList)
                    {
                        Advertising.Add(new AdvertisingDto(el.Purchase, el.Cost, el.Type, el.Info, el.Picture));
                        num += 1;
                        if (num == 3)
                        {
                            break;
                        }
                    }
                }

            }
            if(Advertising.Count!=0)
            {
                while (num < 3)
                {
                    Advertising.Add(Advertising[0]);
                    num += 1;
                }
                return Advertising;
            }
            else
            {
                return Advertising;
            }
        }
    }
}
