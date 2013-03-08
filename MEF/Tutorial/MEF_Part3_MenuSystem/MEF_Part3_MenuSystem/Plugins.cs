using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace MEF_Part3_MenuSystem
{
    [Export("Size",typeof(IMenuPlugin))]
    class SizeUpPlugin : IMenuPlugin
    {
        public string MenuText
        {
            get { return "Size + 10"; }
        }

        public void ChangeLabel(System.Windows.Forms.Label label)
        {
            label.Font = new System.Drawing.Font(label.Font.FontFamily, label.Font.Size + 10.0f);
        }
    }

    [Export("Size", typeof(IMenuPlugin))]
    class SizeDownPlugin : IMenuPlugin
    {
        public string MenuText
        {
            get { return "Size - 10"; }
        }

        public void ChangeLabel(System.Windows.Forms.Label label)
        {
            label.Font = new System.Drawing.Font(label.Font.FontFamily, label.Font.Size - 10.0f);
        }
    }

    [Export("Color", typeof(IMenuPlugin))]
    class ColorRedPlugin : IMenuPlugin
    {
        public string MenuText
        {
            get { return "Red"; }
        }

        public void ChangeLabel(System.Windows.Forms.Label label)
        {
            label.ForeColor = System.Drawing.Color.Red;
        }
    }


    [Export("Color", typeof(IMenuPlugin))]
    class ColorBluePlugin : IMenuPlugin
    {
        public string MenuText
        {
            get { return "Blue"; }
        }

        public void ChangeLabel(System.Windows.Forms.Label label)
        {
            label.ForeColor = System.Drawing.Color.Blue;
        }
    }


}
