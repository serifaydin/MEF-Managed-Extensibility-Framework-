namespace MEFWINDOWS.MODULES
{
    public interface IModule
    {
        string ModuleName { get; }
        object ModuleContent { get; }
        string ModuleCode { get; }
        void ShowModule();
        ModuleInfo ModuleInfo();
    }
}