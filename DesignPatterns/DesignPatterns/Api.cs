namespace DesignPatterns
{
    public class Core<T>
    {
        public static Api.FluentInterface.iFactory<object> Report()
        {
            return new Api.FluentInterface.Factory();
        }
    }
}
