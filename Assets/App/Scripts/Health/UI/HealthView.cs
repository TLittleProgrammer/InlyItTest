using System;
using App.Scripts.SceneContainer.Installer;
using TMPro;
using UnityEngine;

namespace App.Scripts.InteractiveItems.UI
{
    public class HealthView : MonoBehaviour, IInitializable<HealthViewModel>
    {
        [SerializeField] private TMP_Text _healthText;
        
        private HealthViewModel _viewModel;

        public void Initialize(HealthViewModel viewModel)
        {
            _viewModel = viewModel;
            _viewModel.HealthPoints.OnChanged += OnHealthPointsChanged;
        }

        private void OnEnable()
        {
            if (_viewModel is not null)
            {
                _viewModel.HealthPoints.OnChanged += OnHealthPointsChanged;
            }
        }

        private void OnDisable()
        {
            _viewModel.HealthPoints.OnChanged -= OnHealthPointsChanged;
        }

        private void OnHealthPointsChanged(int newValue)
        {
            _healthText.text = newValue.ToString();
        }
    }
}