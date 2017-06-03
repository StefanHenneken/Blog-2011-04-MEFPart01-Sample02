using System;
using System.ComponentModel.Composition;

namespace CarMercedes
{
    public class Mercedes
    {
        [Export("CarContract")]
        public string StartEngine(string name)
        {           
            return String.Format("{0} starts the Mercedes.", name);
        }
    }
}
