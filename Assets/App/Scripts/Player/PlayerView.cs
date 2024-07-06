using System;
using UnityEngine;

namespace App.Scripts.Player
{
    public class PlayerView : MonoBehaviour, ITriggerColliderable
    {
        public CharacterController CharacterController;

        public event Action<Collider> EnterCollised;
        public event Action<Collider> ExitCollised;

        private void OnTriggerEnter(Collider other)
        {
            EnterCollised?.Invoke(other);
        }

        private void OnTriggerExit(Collider other)
        {
            ExitCollised?.Invoke(other);
        }
    }
}