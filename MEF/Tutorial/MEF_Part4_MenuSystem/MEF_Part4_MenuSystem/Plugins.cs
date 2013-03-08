using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace MEF_Part4_MenuSystem
{
    class GlobalString
    {
        public const string MENUTEXT_KEY = "MenuText";
    }


    [Export("Size", typeof(IMenuPlugin))]
    [ExportMetadata(GlobalString.MENUTEXT_KEY,"Size +10")]
    class SizeUpPlugin : IMenuPlugin
    {
        public void ChangeLabel(System.Windows.Forms.Label label)
        {
            label.Font = new System.Drawing.Font(label.Font.FontFamily, label.Font.Size + 10.0f);
        }
    }

    [Export("Size", typeof(IMenuPlugin))]
    [ExportMetadata(GlobalString.MENUTEXT_KEY, "Size -10")]
    class SizeDownPlugin : IMenuPlugin
    {
        public void ChangeLabel(System.Windows.Forms.Label label)
        {
            label.Font = new System.Drawing.Font(label.Font.FontFamily, label.Font.Size - 10.0f);
        }
    }

    [Export("Color", typeof(IMenuPlugin))]
    [ExportMetadata(GlobalString.MENUTEXT_KEY, "Red")]
    class ColorRedPlugin : IMenuPlugin
    {
        public void ChangeLabel(System.Windows.Forms.Label label)
        {
            label.ForeColor = System.Drawing.Color.Red;
        }
    }


    [Export("Color", typeof(IMenuPlugin))]
    [ExportMetadata(GlobalString.MENUTEXT_KEY, "Blue")]
    class ColorBluePlugin : IMenuPlugin
    {

        public void ChangeLabel(System.Windows.Forms.Label label)
        {
            label.ForeColor = System.Drawing.Color.Blue;
        }
    }


}
