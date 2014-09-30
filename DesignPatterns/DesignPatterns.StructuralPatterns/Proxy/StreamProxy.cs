namespace DesignPatterns.StructuralPatterns.Proxy
{
    public class StreamProxy:StreamViewer
    {
        private StreamViewer streamViewer;
        public override System.IO.Stream View(string fullPath)
        {
            streamViewer = (streamViewer == null ? new StreamViewer() : streamViewer);
            return  streamViewer.View(fullPath);            
        }
    }
}
