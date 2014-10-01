using System;

namespace DesignPatterns.Api.FluentInterface
{
    public class Factory : iFactory<object>
    {
        private object _model = null;        
        public Factory()
        {
            this._model = new object();
        }
        public override object Assemble()
        {
            return this._model;
        }

        public override iFactory<object> Type(object model)
        {
            this._model = model;
            return this;
        }
    }
}
