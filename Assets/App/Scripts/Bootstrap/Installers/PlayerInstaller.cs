using App.Scripts.Player;
using App.Scripts.Player.Facade;
using App.Scripts.Player.Systems;
using App.Scripts.SceneContainer.Installer;
using UnityEngine;

namespace App.Scripts.Bootstrap.Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private PlayerView _playerView;
        [SerializeField] private Transform _cameraTransform;
        [SerializeField] private PlayerMovementSettings _movementSettings;
        
        protected override void OnInstallBindings()
        {
            PlayerFacade playerFacade = new();
            IPlayerMovementSystem playerMovementSystem = CreatePlayerMovementSystem();
            
            playerFacade.AddModule(playerMovementSystem);
            
            Container.SetService<IPlayerFacade, PlayerFacade>(playerFacade);
            Container.SetService<IUpdatable, PlayerFacade>(playerFacade);
        }

        private IPlayerMovementSystem CreatePlayerMovementSystem()
        {
            PlayerMovementSystem system = Container.CreateInstanceWithArguments<PlayerMovementSystem>(_playerView, _cameraTransform, _movementSettings);
            
            return system;
        }
    }
}