using App.Scripts.Reactive;
using App.Scripts.SceneContainer.Installer;
using UnityEngine;

namespace App.Scripts.InteractiveItems.UI
{
    public class HealthViewModel : IInitializable
    {
        public readonly ReactiveProperty<int> HealthPoints = new();
        
        private readonly HealthModel _healthModel;

        public HealthViewModel(HealthModel healthModel)
        {
            _healthModel = healthModel;
        }

        public void Initialize()
        {
            _healthModel.HealthProperty.OnChanged += OnHealthChanged;
        }

        private void OnHealthChanged(int newHealthValue)
        {
            HealthPoints.Value = newHealthValue;
        }
    }
}