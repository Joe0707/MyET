using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    public class ComputerAwakeSystem : AwakeSystem<Computer>
    {
        public override void Awake(Computer self)
        {
            Log.Debug("ComputeAwake");
        }
    }

    public static class ComputerSystem
    {
        public static void Start(this Computer self)
        {
            Log.Debug("Computer Start!!!");
            self.GetComponent<PCCaseComponent>().StartPower();
            self.GetComponent<MonitorsComponent>().Display();
        }
    }
}
