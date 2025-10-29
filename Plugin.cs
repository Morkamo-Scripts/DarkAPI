using System;
using Exiled.API.Enums;
using Exiled.API.Features;

namespace DarkAPI
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "DarkAPI";
        public override string Prefix => Name;
        public override string Author => "Morkamo";
        public override Version RequiredExiledVersion => new Version(9, 1, 0);
        public override Version Version => new Version(0, 0, 1);
        public override PluginPriority Priority => PluginPriority.Highest;

        public static Plugin Instance;

        public override void OnEnabled()
        {
            Instance = this;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            base.OnDisabled();
        }
    }
}