using App.Scripts.Camera;
using App.Scripts.Player;
using App.Scripts.SceneContainer.Installer;
using UnityEngine;

namespace App.Scripts.Bootstrap.Installers
{
    public class CameraInstaller : MonoInstaller
    {
        [SerializeField] private Transform _cameraTransform;
        [SerializeField] private PlayerView _playerView;
        [SerializeField] private CameraSettings _cameraSettings;
        
        protected override void OnInstallBindings()
        {
            ICameraMovementSystem cameraMovementSystem = new CameraMovementSystem(_playerView, _cameraTransform, _cameraSettings);
            
            Container.SetService<IInitializable, ICameraMovementSystem>(cameraMovementSystem);
            Container.SetService<ILateUpdatable, ICameraMovementSystem>(cameraMovementSystem);
        }
    }
}