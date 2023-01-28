using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class MonitorsComponentSystem
    {
        public static void Display (this MonitorsComponent self)
        {
            Log.Debug("monitors start display!!!!!");
        }
    }
}
