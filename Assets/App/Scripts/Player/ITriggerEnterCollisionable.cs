using System;
using UnityEngine;

namespace App.Scripts.Player
{
    public interface ITriggerEnterCollisionable
    {
        event Action<Collider> EnterCollised;
    }
}