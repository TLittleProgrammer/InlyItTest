using System.Collections.Generic;
using App.Scripts.Bootstrap.Effects;
using App.Scripts.Player.Systems;

namespace App.Scripts.InteractiveItems.Activate.Activators.Speed
{
    public abstract class ChangeSpeedActivator : IInteractiveItemActivator
    {
        private readonly ChangeSpeedSettings _speedSettings;
        private readonly IPlayerMovementSystem _playerMovementSystem;
        private readonly IEffectsActivator _effectsActivator;
        private readonly List<string> _needSpawnEffects;

        protected ChangeSpeedActivator(
            ChangeSpeedSettings speedSettings,
            IPlayerMovementSystem playerMovementSystem,
            IEffectsActivator effectsActivator,
            List<string> needSpawnEffects)
        {
            _speedSettings = speedSettings;
            _playerMovementSystem = playerMovementSystem;
            _effectsActivator = effectsActivator;
            _needSpawnEffects = needSpawnEffects;
        }
        
        public virtual void Activate()
        {
            _playerMovementSystem.AddSpeed(_speedSettings.SpeedOffset);
            
            foreach (string key in _needSpawnEffects)
            {
                _effectsActivator.Activate(key);
            }
        }
    }
}