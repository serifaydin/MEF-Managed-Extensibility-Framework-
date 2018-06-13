using MEF_Github.Modules;
using System.ComponentModel.Composition;

namespace MEF_Github.Module1
{
    [Export(typeof(IModule))]
    public class MefModule : IModule
    {
        public string GetModuleCode()
        {
            return "GetModuleCode 1";
        }

        public string GetModuleName()
        {
            return "GetModuleName 1";
        }
    }
}
