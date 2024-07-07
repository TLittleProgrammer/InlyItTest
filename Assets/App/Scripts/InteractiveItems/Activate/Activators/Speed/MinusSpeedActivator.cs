using System.Collections.Generic;
using App.Scripts.Bootstrap.Effects;
using App.Scripts.Player.Systems;

namespace App.Scripts.InteractiveItems.Activate.Activators.Speed
{
    public class MinusSpeedActivator : ChangeSpeedActivator
    {
        public MinusSpeedActivator(
            ChangeSpeedSettings speedSettings,
            IPlayerMovementSystem playerMovementSystem,
            IEffectsActivator effectsActivator,
            List<string> needSpawnEffects) : base(speedSettings, playerMovementSystem, effectsActivator, needSpawnEffects)
        {
        }
    }
}