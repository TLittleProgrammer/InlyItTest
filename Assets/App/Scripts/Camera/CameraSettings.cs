using UnityEngine;

namespace App.Scripts.Camera
{
    [CreateAssetMenu(menuName = "Configs/CameraSettings", fileName = "CameraSettings")]
    public sealed class CameraSettings : ScriptableObject
    {
        public Vector3 PositionOffset;
        public Vector3 InitialRotation;
    }
}