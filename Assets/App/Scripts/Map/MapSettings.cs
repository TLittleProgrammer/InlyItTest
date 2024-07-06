using UnityEngine;

namespace App.Scripts.Installers
{
    [CreateAssetMenu(menuName = "Configs/MapSettings", fileName = "MapSettings")]
    public class MapSettings : ScriptableObject
    {
        public Vector3 InitialScale;
    }
}