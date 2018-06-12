namespace DesignPatterns.Creational.AbstractFactory.ConcreteProduct
{
    using AbstractProduct;

    public class I3 : IProcessor
    {
        public string GetProcessor()
        {
            return Enums.Processors.i3.ToString();
        }
    }

    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Enums.Processors.i5.ToString();
        }
    }

    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Enums.Processors.i7.ToString();
        }
    }

}
