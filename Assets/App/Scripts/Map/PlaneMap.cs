using UnityEngine;

namespace App.Scripts.Map
{
    public sealed class PlaneMap : MonoBehaviour, IMap
    {
        public void ChangeMapScale(Vector3 targetScale)
        {
            transform.localScale = targetScale;
        }

        public Vector3 GetSizeInUniMetres()
        {
            return transform.localScale * 10f;
        }

        public Vector3 GetPosition()
        {
            return transform.position;
        }
    }
}