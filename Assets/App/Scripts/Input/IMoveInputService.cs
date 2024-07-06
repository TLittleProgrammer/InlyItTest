using UnityEngine;

namespace App.Scripts.Input
{
    public interface IMoveInputService
    {
        Vector3 Axis { get; }
    }
}