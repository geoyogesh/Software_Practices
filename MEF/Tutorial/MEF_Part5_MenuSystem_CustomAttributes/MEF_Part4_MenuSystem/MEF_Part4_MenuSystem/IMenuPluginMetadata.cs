using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEF_Part4_MenuSystem
{
    /// <summary>
    /// Remove public setters
    /// </summary>
    public interface IMenuPluginMetadata
    {
        string MenuText { get; } 
    }
}
