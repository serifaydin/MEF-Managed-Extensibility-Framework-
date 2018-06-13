using MEFWINDOWS.MODULES;
using System.ComponentModel.Composition;

namespace MEFWINDOWS.WFA_Module2
{
    [Export(typeof(IModule))]
    public class ModuleManager : IModule
    {
        public string ModuleName
        {
            get
            {
                return "ModuleName 2";
            }
        }

        public object ModuleContent
        {
            get
            {
                return "ModuleContent 2";
            }
        }

        public string ModuleCode
        {
            get
            {
                return "ModuleCode 2";
            }
        }

        public ModuleInfo ModuleInfo()
        {
            return new ModuleInfo()
            {
                Code = "ModuleInfo Code 2",
                Name = "ModuleInfo Name 2"
            };
        }

        public void ShowModule()
        {
            Form1 frm = new Form1();
            frm.Tag = ModuleName;
            frm.Text = ModuleName;
            frm.MdiParent = System.Windows.Forms.Application.OpenForms["frmEngine"];
            frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}