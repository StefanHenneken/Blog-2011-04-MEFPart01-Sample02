using System;
using System.ComponentModel.Composition;

namespace CarBMW
{   
    public class BMW
    {
        [Export("CarContract")]
        public string StartEngine(string name)
        {
            return String.Format("{0} starts the BMW.", name);
        }
    }
}
