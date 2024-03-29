using Madbus.Common;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madbus
{
    internal class MainPageViewModel
    {
        public string Title { get; } = "Madbus";

        public ObservableCollection<CategoryBase> Categories { get; }

        public MainPageViewModel()
        {
            FontIcon icon = new FontIcon
            {
                Glyph = "\uE7F9"
            };

            Categories = new ObservableCollection<CategoryBase>
            {
                new Category { Name = "ModbusTcpClient", Glyph = icon, Tooltip = "this is modbus tcp client"},
            };

        }

    }
}
