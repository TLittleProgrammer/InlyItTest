using System;

namespace App.Scripts.Bootstrap.Effects
{
    public interface IEffect
    {
        event Action<EffectView> Disabled;
    }
}