using App.Scripts.External.ObjectPool;

namespace App.Scripts.Bootstrap.Effects
{
    public class EffectsActivator : IEffectsActivator
    {
        private readonly IKeyObjectPool<EffectView> _keyObjectPool;

        public EffectsActivator(IKeyObjectPool<EffectView> keyObjectPool)
        {
            _keyObjectPool = keyObjectPool;
        }
        
        public EffectView Activate(string key)
        {
            var effect = _keyObjectPool.Spawn(key);
            effect.ParticleSystem.Play();

            effect.Disabled += effectView =>
            {
                OnEffectDisabled(key, effectView);
            };
            
            return effect;
        }

        private void OnEffectDisabled(string key, EffectView effectView)
        {
            _keyObjectPool.Despawn(key, effectView);
        }
    }
}