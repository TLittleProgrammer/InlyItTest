using System;
using UnityEngine;

namespace App.Scripts.Player
{
    public interface ITriggerExitCollisionable
    {
        event Action<Collider> ExitCollised;
    }
}