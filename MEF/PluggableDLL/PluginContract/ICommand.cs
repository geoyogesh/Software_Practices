using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginContract
{
    public interface ICommand
    {
        void DoWork(int num1, int num2);
    }
}
