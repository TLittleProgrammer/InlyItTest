using UnityEngine;

namespace App.Scripts.Player.Systems
{
    [CreateAssetMenu(menuName = "Configs/MovementSettings", fileName = "")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float Speed;
    }
}