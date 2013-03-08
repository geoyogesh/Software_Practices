using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MEF_Part4_MenuSystem
{
    interface IMenuPlugin
    {
        void ChangeLabel(Label label);
    }
}
