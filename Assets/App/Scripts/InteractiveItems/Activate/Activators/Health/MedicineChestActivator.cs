using System.Collections.Generic;
using App.Scripts.Bootstrap.Effects;

namespace App.Scripts.InteractiveItems
{
    public sealed class MedicineChestActivator : ChangeHealthActivator
    {
        public MedicineChestActivator(
            ChangeHealthSettings healthSettings,
            IHealthSystem healthSystem,
            IEffectsActivator effectsActivator,
            List<string> needSpawnEffects) : base(healthSettings, healthSystem, effectsActivator, needSpawnEffects)
        {
        }
    }
}