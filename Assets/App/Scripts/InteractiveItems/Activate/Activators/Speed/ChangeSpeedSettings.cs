using UnityEngine;

namespace App.Scripts.InteractiveItems.Activate.Activators.Speed
{
    [CreateAssetMenu(menuName = "Configs/ChangeSpeedSettings", fileName = "ChangeSpeedSettings")]
    public class ChangeSpeedSettings : ScriptableObject
    {
        public float SpeedOffset;
    }
}