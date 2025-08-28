using ModConfigMenu;
using ModConfigMenu.Objects;
using System.Collections.Generic;

namespace MapMoveSpeed.Mcm
{
    internal class McmConfiguration : McmConfigurationBase<ModConfig>
    {

        public McmConfiguration(ModConfig config, Logger logger) : base (config, logger) { }

        public override void Configure()
        {
            ModConfigMenuAPI.RegisterModConfig("Map Move Speed", new List<ConfigValue>()
            {
                CreateConfigProperty(nameof(ModConfig.BorderMoveSpeed),
                    "The speed of the mouse move.  The game defaults to 4.",
                    1,32),
                CreateReadOnly(nameof(ModConfig.SpeedKey)),
            }, OnSave);
        }

        protected override bool OnSave(Dictionary<string, object> currentConfig, out string feedbackMessage)
        {
            bool isSuccess = base.OnSave(currentConfig, out feedbackMessage);

            if(isSuccess)
            {
                GameCamera_LateUpdate_Patch.Init();
            }

            return isSuccess;  
        }
    }
}
