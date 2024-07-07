using System.Collections.Generic;
using App.Scripts.Bootstrap.Effects;

namespace App.Scripts.InteractiveItems
{
    public abstract class ChangeHealthActivator : IInteractiveItemActivator
    {
        private readonly ChangeHealthSettings _healthSettings;
        private readonly IHealthSystem _healthSystem;
        private readonly IEffectsActivator _effectsActivator;
        private readonly List<string> _needSpawnEffects;

        protected ChangeHealthActivator(
            ChangeHealthSettings healthSettings,
            IHealthSystem healthSystem,
            IEffectsActivator effectsActivator,
            List<string> needSpawnEffects)
        {
            _healthSettings = healthSettings;
            _healthSystem = healthSystem;
            _effectsActivator = effectsActivator;
            _needSpawnEffects = needSpawnEffects;
        }
        
        public virtual void Activate()
        {
            _healthSystem.ChangeHealth(_healthSettings.HealthOffset);

            foreach (string key in _needSpawnEffects)
            {
                _effectsActivator.Activate(key);
            }
        }
    }
}