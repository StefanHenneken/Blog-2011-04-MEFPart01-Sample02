using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace CarHost
{
    class Program
    {
        [ImportMany("CarContract")]
        private Func<string, string>[] startCars = null;
       
        static void Main(string[] args)
        {
            new Program().Run();
        }
        void Run()
        {          
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
            foreach (Func<string, string> start in startCars)
                Console.WriteLine(start("Sebastian"));
        }
    }
}
