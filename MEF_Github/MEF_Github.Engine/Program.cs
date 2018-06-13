using MEF_Github.Modules;
using System;

namespace MEF_Github.Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            EngineLibrary library = new EngineLibrary();
            library.OneEngineLibrary(@"../../lib");

            Console.WriteLine("Modül Adı : " + library.module.GetModuleName());
            Console.WriteLine("--------");
            Console.WriteLine("Modül Kodu : " + library.module.GetModuleCode());
            Console.WriteLine("########");

            MultiEngineLibrary multiLibrary = new MultiEngineLibrary(@"../../libs");
            foreach (IModule item in multiLibrary.Modules)
            {
                Console.WriteLine("Modül Adı : " + item.GetModuleName());
                Console.WriteLine("--------");
                Console.WriteLine("Modül Kodu : " + item.GetModuleCode());
                Console.WriteLine("*******");
            }

            Console.ReadKey();
        }
    }
}