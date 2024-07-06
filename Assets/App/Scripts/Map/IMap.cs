using App.Scripts.Player;
using UnityEngine;

namespace App.Scripts.Map
{
    public interface IMap
    {
        void ChangeMapScale(Vector3 targetScale);
        Vector3 GetSizeInUniMetres();
        Vector3 GetPosition();
    }
}