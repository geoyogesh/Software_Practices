using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using System.ComponentModel.Composition.Primitives;

namespace MEF_PART1
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyCatalog catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            CompositionContainer container = new CompositionContainer(catalog);

            foreach (ComposablePartDefinition p in container.Catalog.Parts)
            {
                Console.WriteLine(p.ToString());
            }
            Console.ReadKey();
        }
    }

    //
    //[InheritedExport]
    //[Export]
    sealed class ClassA : IClass 
    {
        
    }

    //[Export]
    sealed class ClassB : IClass 
    {
        
    }

    class ClassC
    {
        
    }

    /// <summary>
    /// Export - Applied to only to class
    /// InheritedExport - Applied to both class and interface
    /// Use sealed classes to stop inheritance cycle loop
    /// </summary>

    [InheritedExport]
    interface IClass
    {
        
    }

}
