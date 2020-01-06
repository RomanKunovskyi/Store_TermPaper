using Dal.Concrete;

namespace DalFactory.Abstract
{
    public interface IFactory
    {
        AdvertisingDal Advertising();
        PersonDal Person();
        ProductDal Product();
        PurchaseHistoryDal PurchaseHistory();
        SpecialQuestionDal SpecialQuestion();
        UserDal User();
    }
}
