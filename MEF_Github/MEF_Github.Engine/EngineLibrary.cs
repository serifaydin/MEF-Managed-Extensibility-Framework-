using MEF_Github.Modules;
using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;

namespace MEF_Github.Engine
{
    public class EngineLibrary
    {
        [Import(typeof(IModule))]
        public IModule module;

        public void OneEngineLibrary(string File)
        {
            Console.WriteLine("------Tek Modül-----------");

            try
            {
                var catalog = new AggregateCatalog();
                catalog.Catalogs.Add(new AssemblyCatalog(typeof(EngineLibrary).Assembly));
                catalog.Catalogs.Add(new DirectoryCatalog(File, "*.dll"));

                CompositionContainer _container = new CompositionContainer(catalog);
                _container.ComposeParts(this);

            }
            catch (FileNotFoundException)
            {

            }
            catch (CompositionException) // Belirtilen yol içerisi boş ise
            {

            }
            catch (DirectoryNotFoundException) // Belirtilen yol doğru değil ise
            {

            }
        }
    }
}