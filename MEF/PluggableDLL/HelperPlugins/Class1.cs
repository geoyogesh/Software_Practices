using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperPlugins
{
    [Export(typeof(PluginContract.ICommand))]
    public class Add : PluginContract.ICommand
    {
        #region Interface members
        public int GetNumber(int num1, int num2)
        {
            return num1 + num2;
        }
        #endregion
    }
}
