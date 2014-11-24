using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceWithNinject
{
    public class Repository : IRepository
    {
        public IEnumerable<Widget> GetWidgets()
        {
            return new[] {
                new Widget {Name = "Widget1", Price=11},
                new Widget {Name = "Widget2", Price=22}
            };
        }
    }
    public interface IRepository
    {
        IEnumerable<Widget> GetWidgets();
    }
    public class Widget
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}