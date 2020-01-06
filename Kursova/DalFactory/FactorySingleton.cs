using DalFactory.Abstract;
using DalFactory.Concrete;

namespace DalFactory
{
    public class FactorySingleton
    {
        private static FactorySingleton instance;
        public IFactory Dal = new Factory(); //change
        private FactorySingleton()
        {
        }
        public static FactorySingleton GetDal()
        {
            if (instance == null)
                instance = new FactorySingleton();
            return instance;
        }
    }
}
