using System;
using App.Scripts.InteractiveItems;
using UnityEngine;

namespace App.Scripts.Player.Systems
{
    public class PlayerCollisionSystem : IPlayerCollisionSystem
    {
        private readonly ITriggerColliderable _playerEnterCollisionable;
        private readonly IUIInteractiveItemSystem _uiInteractiveItemSystem;

        public PlayerCollisionSystem(ITriggerColliderable playerEnterCollisionable, IUIInteractiveItemSystem uiInteractiveItemSystem)
        {
            _playerEnterCollisionable = playerEnterCollisionable;
            _uiInteractiveItemSystem = uiInteractiveItemSystem;
        }

        public void Initialize()
        {
            _playerEnterCollisionable.EnterCollised += OnPlayerEnterCollised;
            _playerEnterCollisionable.ExitCollised  += OnPlayerExitCollised;
        }

        private void OnPlayerEnterCollised(Collider obj)
        {
            Process(obj, _uiInteractiveItemSystem.AddItem);
        }

        private void OnPlayerExitCollised(Collider obj)
        {
            Process(obj, _uiInteractiveItemSystem.RemoveItem);
        }

        private void Process(Collider collision, Action<InteractiveType> processAction)
        {
            if (collision.TryGetComponent(out IInteractiveItem interactiveItem))
            {
                processAction.Invoke(interactiveItem.InteractiveType);
            }
        }
    }
}