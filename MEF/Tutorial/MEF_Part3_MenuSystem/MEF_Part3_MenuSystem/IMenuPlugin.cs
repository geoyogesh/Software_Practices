using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MEF_Part3_MenuSystem
{
    interface IMenuPlugin
    {
        string MenuText { get; }
        void ChangeLabel(Label label);
    }
}
