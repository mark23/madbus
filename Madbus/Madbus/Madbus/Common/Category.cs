using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madbus.Common
{
    internal class CategoryBase { }

    internal class Category : CategoryBase
    {
        public string Name { get; set; }
        public string Tooltip { get; set; }
        //public Symbol Glyph { get; set; }
        public FontIcon Glyph { get; set; }
    }

    internal class Separator : CategoryBase { }

    internal class Header : CategoryBase
    {
        public string Name { get; set; }
    }
}
