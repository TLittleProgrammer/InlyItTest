using System.Collections.Generic;
using App.Scripts.Bootstrap.Effects;
using App.Scripts.Player.Systems;

namespace App.Scripts.InteractiveItems.Activate.Activators.Speed
{
    public class AddSpeedActivator : ChangeSpeedActivator
    {
        public AddSpeedActivator(
            ChangeSpeedSettings speedSettings,
            IPlayerMovementSystem playerMovementSystem,
            IEffectsActivator effectsActivator,
            List<string> needSpawnEffects) : base(speedSettings, playerMovementSystem, effectsActivator, needSpawnEffects)
        {
        }
    }
}