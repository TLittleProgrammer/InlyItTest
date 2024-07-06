using System;
using App.Scripts.InteractiveItems;
using UnityEngine;

namespace App.Scripts.Player.Systems
{
    public class PlayerCollisionSystem : IPlayerCollisionSystem
    {
        private readonly ITriggerColliderable _playerEnterCollisionable;
        private readonly IInteractiveSystem _interactiveSystem;

        public PlayerCollisionSystem(
            ITriggerColliderable playerEnterCollisionable,
            IInteractiveSystem interactiveSystem)
        {
            _playerEnterCollisionable = playerEnterCollisionable;
            _interactiveSystem = interactiveSystem;
        }

        public void Initialize()
        {
            _playerEnterCollisionable.EnterCollised += OnPlayerEnterCollised;
            _playerEnterCollisionable.ExitCollised  += OnPlayerExitCollised;
        }

        private void OnPlayerEnterCollised(Collider obj)
        {
            Process(obj, _interactiveSystem.EnterInteractive);
        }

        private void OnPlayerExitCollised(Collider obj)
        {
            Process(obj, _interactiveSystem.ExitInteractive);
        }

        private void Process(Collider collision, Action<IInteractiveItem> processAction)
        {
            if (collision.TryGetComponent(out IInteractiveItem interactiveItem))
            {
                processAction.Invoke(interactiveItem);
            }
        }
    }
}