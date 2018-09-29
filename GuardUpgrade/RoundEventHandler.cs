using System;
using Smod2;
using Smod2.API;
using Smod2.EventHandlers;
using Smod2.Events;

namespace GuardUpgrade
{
    class RoundEventHandler : IEventHandlerCheckEscape
    {
        private Plugin plugin;

        public RoundEventHandler(Plugin plugin)
        {
            this.plugin = plugin;
        }

        public void OnCheckEscape(PlayerCheckEscapeEvent ev)
        {
            if (ev.Player.TeamRole.Role.Equals(Role.FACILITY_GUARD) && plugin.GetConfigBool("gaurd_upgrade"))
            {
                ev.Player.ChangeRole(Role.NTF_CADET);
            }
        }
    }
}
