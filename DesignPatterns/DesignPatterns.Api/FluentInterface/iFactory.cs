namespace DesignPatterns.Api.FluentInterface
{
    public abstract class iFactory<T>
    {
        public abstract iFactory<T> Type(T model);
        public abstract T Assemble();
    }
}
