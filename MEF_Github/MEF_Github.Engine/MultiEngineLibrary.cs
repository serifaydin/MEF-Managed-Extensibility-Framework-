using MEF_Github.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;

namespace MEF_Github.Engine
{
    public class MultiEngineLibrary
    {
        [ImportMany(typeof(IModule))]
        public IEnumerable<IModule> Modules { get; set; }

        public MultiEngineLibrary(string File)
        {
            Console.WriteLine("------Çoklu Modül-------");

            try
            {
                var catalog = new AggregateCatalog();
                catalog.Catalogs.Add(new AssemblyCatalog(typeof(MultiEngineLibrary).Assembly));
                catalog.Catalogs.Add(new DirectoryCatalog(File, "*.dll"));

                CompositionContainer container = new CompositionContainer(catalog);

                var batch = new CompositionBatch();
                batch.AddPart(this);

                container.Compose(batch);
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