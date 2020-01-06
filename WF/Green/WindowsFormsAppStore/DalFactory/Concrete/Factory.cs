using Dal.Concrete;
using DalFactory.Abstract;

namespace DalFactory.Concrete
{
    public sealed class Factory : IFactory
    {
        public AdvertisingDal Advertising()
        {
            return new AdvertisingDal();
        }

        public PersonDal Person()
        {
            return new PersonDal();
        }

        public ProductDal Product()
        {
            return new ProductDal();
        }

        public PurchaseHistoryDal PurchaseHistory()
        {
            return new PurchaseHistoryDal();
        }

        public SpecialQuestionDal SpecialQuestion()
        {
            return new SpecialQuestionDal();
        }

        public UserDal User()
        {
            return new UserDal();
        }
    }
}
