using System;
using UnityEngine;

namespace App.Scripts.Bootstrap.Effects
{
    public class EffectView : MonoBehaviour, IEffect
    {
        public ParticleSystem ParticleSystem;
        
        public event Action<EffectView> Disabled;

        private void OnDisable()
        {
            Disabled?.Invoke(this);
        }
    }
}