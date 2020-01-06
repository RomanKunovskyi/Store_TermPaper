using Dto;
using System.Collections.Generic;

namespace Bll.Abstract
{
    public interface IAdvertisingBll
    {
        List<AdvertisingDto> GetAdvertising();
        List<AdvertisingDto> GetAdvertising(List<string> tags);
    }
}
