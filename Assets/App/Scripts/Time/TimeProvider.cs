using System;

namespace App.Scripts.Time
{
    public sealed class TimeProvider : ITimeProvider
    {
        private float _timeScale = 1f;
        
        public event Action<float> TimeScaleChanged;
        
        public float DeltaTime => UnityEngine.Time.deltaTime * _timeScale;
        
        public float TimeScale
        {
            get => _timeScale;
            set
            {
                _timeScale = value < 0f ? 0f : value;
                
                TimeScaleChanged?.Invoke(_timeScale);
            }
        }
    }
}