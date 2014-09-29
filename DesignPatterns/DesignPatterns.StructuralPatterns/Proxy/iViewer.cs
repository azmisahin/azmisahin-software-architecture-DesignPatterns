namespace DesignPatterns.StructuralPatterns.Proxy
{
    public abstract class iViewer<T>
    {
        public abstract T View(string fullPath);
    }
}
