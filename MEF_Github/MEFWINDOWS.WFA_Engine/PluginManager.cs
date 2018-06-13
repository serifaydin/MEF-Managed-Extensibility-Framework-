using MEFWINDOWS.MODULES;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;

namespace MEFWINDOWS.WFA_Engine
{
    public class PluginManager
    {
        [ImportMany(typeof(IModule))]
        public IEnumerable<IModule> Modules { get; set; }

        public PluginManager(string File)
        {
            try
            {
                var catalog = new AggregateCatalog();
                catalog.Catalogs.Add(new AssemblyCatalog(typeof(PluginManager).Assembly));
                catalog.Catalogs.Add(new DirectoryCatalog(File, "*.dll"));

                CompositionContainer container = new CompositionContainer(catalog);

                var batch = new CompositionBatch();
                batch.AddPart(this);

                container.Compose(batch);
            }
            catch (FileNotFoundException fex)
            {

            }
            catch (CompositionException cex) // Belirtilen yol içerisi boş ise.
            {

            }
            catch (DirectoryNotFoundException dex) // Belirtilen yol doğru değil ise.
            {

            }
        }
    }
}