namespace DesignPatterns.Api.FluentInterface
{
    public class Fluent
    {
        public static iFactory<object> Start()
        {
            return new Factory();
        }
    }
}
