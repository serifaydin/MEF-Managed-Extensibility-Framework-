using MEFWINDOWS.MODULES;
using System.ComponentModel.Composition;

namespace MEFWINDOWS.WFA_Module1
{
    [Export(typeof(IModule))]
    public class ModuleManager : IModule
    {
        public string ModuleName
        {
            get
            {
                return "ModuleName 1";
            }
        }

        public object ModuleContent
        {
            get
            {
                return "ModuleContent 1";
            }
        }

        public string ModuleCode
        {
            get
            {
                return "ModuleCode 1";
            }
        }

        public ModuleInfo ModuleInfo()
        {
            return new ModuleInfo()
            {
                Code = "ModuleInfo Code 1",
                Name = "ModuleInfo Name 1"
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