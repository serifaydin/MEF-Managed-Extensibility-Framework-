using MEFWINDOWS.MODULES;
using System;
using System.Windows.Forms;

namespace MEFWINDOWS.WFA_Engine
{
    public partial class frmEngine : Form
    {
        public frmEngine()
        {
            InitializeComponent();
        }
        PluginManager manager;

        private void frmEngine_Load(object sender, EventArgs e)
        {
            manager = new PluginManager(@"../../Libs");
            foreach (IModule item in manager.Modules)
            {
                ToolStripMenuItem SSmenu = new ToolStripMenuItem();
                SSmenu.Text = item.ModuleName;
                SSmenu.Tag = item.ModuleCode;
                SSmenu.Click += new EventHandler(ChildClick);

                menuStrip.Items.Add(SSmenu);
            }
        }

        private void ChildClick(object sender, EventArgs e)
        {
            ToolStripMenuItem itm = (ToolStripMenuItem)sender;
            foreach (IModule item in manager.Modules)
            {
                if (item.ModuleCode == (string)itm.Tag)
                {
                    item.ShowModule();
                    return;
                }
            }
        }
    }
}
