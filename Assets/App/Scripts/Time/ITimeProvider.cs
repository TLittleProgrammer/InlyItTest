using System;
using App.Scripts.SceneContainer.Installer;

namespace App.Scripts.Time
{
    public interface ITimeProvider
    {
        event Action<float> TimeScaleChanged;
        
        float DeltaTime { get; }
        float TimeScale { get; set; }
    }
}