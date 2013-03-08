using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace MEF_Part4_MenuSystem
{
    public partial class Form1 : Form
    {
        [ImportMany("Size")]
        private IEnumerable<Lazy<IMenuPlugin, IMenuPluginMetadata>> sizePlugins;
        [ImportMany("Color")]
        private IEnumerable<Lazy<IMenuPlugin, IMenuPluginMetadata>> colorPlugins;



        public Form1()
        {
            AssemblyCatalog catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            CompositionContainer container = new CompositionContainer(catalog);

            container.ComposeParts(this);


            InitializeComponent();
        }

        private void menusystem_load(object sender, EventArgs e)
        {

            InitializeMenus();
        }

        private void InitializeMenus()
        {
            var sizeMenu = new ToolStripMenuItem("Size");
            var colorMenu = new ToolStripMenuItem("Color");

            foreach (var p in sizePlugins)
            {
                sizeMenu.DropDownItems.Add(BuildMenuItem(p));
            }

            foreach (var p in colorPlugins)
            {
                colorMenu.DropDownItems.Add(BuildMenuItem(p));
            }
            menuStrip1.Items.Add(sizeMenu);
            menuStrip1.Items.Add(colorMenu);
        }

        private ToolStripMenuItem BuildMenuItem(Lazy<IMenuPlugin, IMenuPluginMetadata> itemDefinition)
        {
            ToolStripMenuItem menuitem = new ToolStripMenuItem();
            menuitem.Text = itemDefinition.Metadata.MenuText;
            menuitem.Click += new EventHandler(menuitem_Click);
            menuitem.Tag = itemDefinition;
            return menuitem;
        }

        void menuitem_Click(object sender, EventArgs e)
        {
            Lazy<IMenuPlugin, IMenuPluginMetadata> plugin = ((ToolStripMenuItem)sender).Tag as Lazy<IMenuPlugin, IMenuPluginMetadata>;
            plugin.Value.ChangeLabel(this.label1);
        }

    }
}
