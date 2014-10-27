using DesignPatterns.Models;
namespace DesignPatterns.StructuralPatterns.Adapter
{
    #region Sample Data
    public class AdaptorData
    {
        public int id { get; set; }
        public object data { get; set; }
    }    
    #endregion
    

    public interface iAdapte
    {
        void Convert(AdaptorData model);
    }
    public class Adapte
    {   void Convert(AdaptorData model)
        {
            var ret = model.data;
        }
    }
    public class StringAdapte : iAdapte
    {
        public void Convert(AdaptorData model)
        {
            var ret = model.data.ToString();
        }
    }
    public class IntAdapte : iAdapte
    {
        public void Convert(AdaptorData model)
        {
            var ret = (int)model.data;
        }
    }
}
