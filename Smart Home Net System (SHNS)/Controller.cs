using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Home_Net_System__SHNS_
{
    public sealed class Controller
    {
        // Controller is a unique appliance (and singleton-type class),
        // which receives inputs from the "Control Panel" and the sensors,
        // processes them and sends instructions to executing devices

        private static Controller instance = null;
        private static readonly object padlock = new object();

        Controller()
        {
        }

        public static Controller Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Controller();
                    }
                    return instance;
                }
            }
        }
    }
}
