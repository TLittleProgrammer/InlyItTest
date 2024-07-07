using App.Scripts.Reactive;
using App.Scripts.SceneContainer.Installer;
using UnityEngine;

namespace App.Scripts.InteractiveItems.UI
{
    public class HealthModel : IInitializable
    {
        public readonly ReactiveProperty<int> HealthProperty = new();
        
        private readonly IHealthSystem _healthSystem;

        public HealthModel(IHealthSystem healthSystem)
        {
            _healthSystem = healthSystem;
        }

        public void Initialize()
        {
            _healthSystem.HealthChanged += OnHealthChanged;
        }

        private void OnHealthChanged(int healthValue)
        {
            HealthProperty.Value = healthValue;
        }
    }
}