using UnityEngine;

namespace App.Scripts.InteractiveItems
{
    public sealed class GetDamageActivator : ChangeHealthActivator
    {
        public GetDamageActivator(ChangeHealthSettings healthSettings, IHealthSystem healthSystem) : base(healthSettings, healthSystem)
        {
        }
    }
}