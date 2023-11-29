namespace AbstractFactory
{
    public abstract class ProductA
    {

    }
    public abstract class ProductB
    {

    }

    public class ProductA2 : ProductA
    {

    }

    public class ProductA1 : ProductA
    {

    }
    public class ProductB1 : ProductB
    {

    }

    public class ProductB2 : ProductB
    {

    }

    public class Client
    {
        public AbstarctFactory? factory;

        public Client(AbstarctFactory f)
        {
           factory = f;
        }

        public void someOperation()
        {
            ProductA pa=factory.createProductA();
            ProductB pb=factory.createProductB();
        }

       
    }

    public interface AbstarctFactory
    {
        public ProductA createProductA();
        public ProductB createProductB();
    }

    public class ConcreteFactory1 : AbstarctFactory
    {

        public ProductA createProductA()
        {
            return  new ProductA1();
        }

        public ProductB createProductB()
        {
            return new ProductB1();
        }
    }

    public class ConcreteFactory2 : AbstarctFactory
    {

        public ProductA createProductA()
        {
            return new ProductA2();
        }

        public ProductB createProductB()
        {
            return new ProductB2();
        }
    }
}