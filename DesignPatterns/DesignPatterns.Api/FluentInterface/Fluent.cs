namespace DesignPatterns.Api.FluentInterface
{
    public class Fluent<T>
    {
        public static iFactory<object> Start()
        {
            return new Factory();
        }
    }
}
