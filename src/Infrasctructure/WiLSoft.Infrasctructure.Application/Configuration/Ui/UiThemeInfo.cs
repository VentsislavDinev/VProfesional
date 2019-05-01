using System;
using System.Collections.Generic;
using System.Text;

namespace WiLSoft.Infrasctructure.Application.Configuration.Ui
{
    public class UiThemeInfo
    {
        public string Name { get; }
        public string CssClass { get; }

        public UiThemeInfo(string name, string cssClass)
        {
            Name = name;
            CssClass = cssClass;
        }
    }
}
