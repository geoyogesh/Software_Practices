using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace MEF_Part4_MenuSystem
{

    [Export("Size", typeof(IMenuPlugin))]
    [MenuPluginMetadataAttribute(MenuText= "Size +10")]
    class SizeUpPlugin : IMenuPlugin
    {
        public void ChangeLabel(System.Windows.Forms.Label label)
        {
            label.Font = new System.Drawing.Font(label.Font.FontFamily, label.Font.Size + 10.0f);
        }
    }

    [Export("Size", typeof(IMenuPlugin))]
    [MenuPluginMetadataAttribute(MenuText = "Size -10")]
    class SizeDownPlugin : IMenuPlugin
    {
        public void ChangeLabel(System.Windows.Forms.Label label)
        {
            label.Font = new System.Drawing.Font(label.Font.FontFamily, label.Font.Size - 10.0f);
        }
    }

    [Export("Color", typeof(IMenuPlugin))]
    [MenuPluginMetadataAttribute(MenuText = "Red")]
    class ColorRedPlugin : IMenuPlugin
    {
        public void ChangeLabel(System.Windows.Forms.Label label)
        {
            label.ForeColor = System.Drawing.Color.Red;
        }
    }


    [Export("Color", typeof(IMenuPlugin))]
    [MenuPluginMetadataAttribute(MenuText = "Blue")]
    class ColorBluePlugin : IMenuPlugin
    {

        public void ChangeLabel(System.Windows.Forms.Label label)
        {
            label.ForeColor = System.Drawing.Color.Blue;
        }
    }


}
