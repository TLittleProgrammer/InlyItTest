using System;

namespace App.Scripts.InteractiveItems
{
    public interface IHealthSystem
    {
        event Action<int> HealthChanged;
        int CurrentHealth { get; }
        
        void ChangeHealth(int changeValue);
    }
}