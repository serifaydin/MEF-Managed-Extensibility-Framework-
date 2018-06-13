using MEF_Github.Modules;
using System.ComponentModel.Composition;

namespace MEF_Github.Module2
{

    [Export(typeof(IModule))]
    public class MefModule : IModule
    {
        public string GetModuleCode()
        {
            return "GetModuleCode 2";
        }

        public string GetModuleName()
        {
            return "GetModuleName 2";
        }
    }
}