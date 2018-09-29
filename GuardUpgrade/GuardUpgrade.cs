using System;
using Smod2;
using Smod2.API;
using Smod2.Attributes;

namespace GuardUpgrade
{
    public class GuardUpgrade
    {
    [PluginDetails(
    author = "Cyanox",
    name = "Guard Upgrade",
    description = "Upgrades gaurds to MTF cadets",
    id = "cyan.gaurd.upgrade",
    version = "0.1",
    SmodMajor = 3,
    SmodMinor = 0,
    SmodRevision = 0
)]
        public class GaurdUpgrade : Plugin
        {
            public override void OnDisable() { }

            public override void OnEnable() { }

            public override void Register()
            {
                this.AddEventHandlers(new RoundEventHandler(this));
                this.AddConfig(new Smod2.Config.ConfigSetting("guard_upgrade", true, Smod2.Config.SettingType.BOOL, true, "Upgrades guard."));
            }
        }
    }
}
