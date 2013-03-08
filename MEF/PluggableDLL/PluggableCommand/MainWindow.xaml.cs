using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PluggableCommand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        [ImportMany]
        public System.Lazy<PluginContract.ICommand,
    IDictionary<string, object>>[] CalciPlugins { get; set; }

        
        public void AssembleCalculatorComponents()
        {
            try
            {
                var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
                var container = new CompositionContainer(catalog);
                container.ComposeParts(this);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        public int GetResult(int num1, int num2, string operationType)
        {
            int result = 0;
            foreach (var CalciPlugin in CalciPlugins)
            {
                if ((string)CalciPlugin.Metadata["CalciMetaData"] == operationType)
                {
                    CalciPlugin.Value.DoWork(num1, num2);
                    break;
                }
            }
            return result;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DoCalciOperation("Add");
        }
        private void DoCaliOperation(string operationType)
        {
            objCompHelper = new CalciCompositionHelper();

            //Assembles the calculator components that will participate in composition
            objCompHelper.AssembleCalculatorComponents();

            //Gets the result
            var result = objCompHelper.GetResult(1, 2, operationType);

            //Display the result
            txtResult.Text = result.ToString();
        }
    }
}
