using UnityEngine;

namespace App.Scripts.Settings
{
    [CreateAssetMenu(menuName = "Configs/GameSettings", fileName = "GameSettings")]
    public class GameSettings : ScriptableObject
    {
        public int MaxHealth;
        public int MinHealth;

        public float MaxSpeed;
        public float MinSpeed;

        public KeyCode UseInteractiveItemKey;
    }
}