using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace MEF_Part4_MenuSystem
{
    [MetadataAttribute]
    class MenuPluginMetadataAttribute : Attribute, IMenuPluginMetadata
    {
        public string MenuText { get; set; }

        //public string MenuText { get; private set; }

        //public MenuPluginMetadataAttribute(string menuText)
        //{
        //    this.MenuText = menuText;
        //}
    }
}
