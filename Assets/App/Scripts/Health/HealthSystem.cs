using System;
using UnityEngine;

namespace App.Scripts.InteractiveItems
{
    public sealed class HealthSystem : IHealthSystem
    {
        private int _health = 100;

        public event Action<int> HealthChanged;

        public int CurrentHealth => _health;

        public void ChangeHealth(int changeValue)
        {
            _health += changeValue;

            if (_health < 0)
            {
                _health = 0;
            }
            
            HealthChanged?.Invoke(_health);
        }
    }
}