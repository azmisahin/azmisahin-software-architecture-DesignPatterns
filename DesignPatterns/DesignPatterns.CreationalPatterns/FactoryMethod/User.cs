using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public abstract class User
    {
        public int UserId { get; set; }
    }

    public abstract class Creator
    {
        public abstract User Factory();
    }

    public class Admin: User
    { }
    public class Create:Creator
    {
        public override User Factory()
        {
            return new Admin();
        }
    }
}
