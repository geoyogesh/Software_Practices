using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace MEF_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyCatalog catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            CompositionContainer container = new CompositionContainer(catalog);

            ImporterClass importer = new ImporterClass();
            container.ComposeParts(importer);



            Console.ReadKey();
        }
    }

    /// <summary>
    /// [Import(AllowDefault=True)] (assigns = o or null)
    /// [Import]
    /// ImportMany
    /// </summary>
    class ImporterClass
    {
        [Import(AllowDefault=true)]
        //[Import]
        private SingleExport singleExport;

        [ImportMany]
        private IEnumerable<ExportBaseClass> multipleExport;
    }

    /// <summary>
    /// Use Abstract keyword to stop it being instansiated so only the inherited class will be intansiated
    /// 
    /// </summary>

    [InheritedExport]
    abstract class ExportBaseClass
	{
		
	}

    class MultipleExport1 : ExportBaseClass
	{
		
	}

    class MultipleExport2 : ExportBaseClass
	{
		
	}

    [Export]
    class SingleExport
    {
        
    }
}
