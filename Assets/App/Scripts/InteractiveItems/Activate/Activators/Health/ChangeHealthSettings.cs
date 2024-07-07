using UnityEngine;

namespace App.Scripts.InteractiveItems
{
    [CreateAssetMenu(menuName = "Configs/ChangeHealth", fileName = "ChangeHealth")]
    public class ChangeHealthSettings : ScriptableObject
    {
        public int HealthOffset;
    }
}