using System.Collections.Generic;
using App.Scripts.Bootstrap.Effects;

namespace App.Scripts.InteractiveItems
{
    public sealed class GetDamageActivator : ChangeHealthActivator
    {
        public GetDamageActivator(
            ChangeHealthSettings healthSettings,
            IHealthSystem healthSystem,
            IEffectsActivator effectsActivator,
            List<string> needSpawnEffects) : base(healthSettings, healthSystem, effectsActivator, needSpawnEffects)
        {
        }
    }
}