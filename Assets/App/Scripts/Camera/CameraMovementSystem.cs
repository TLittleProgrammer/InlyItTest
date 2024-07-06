using App.Scripts.Player;
using UnityEngine;

namespace App.Scripts.Camera
{
    public sealed class CameraMovementSystem : ICameraMovementSystem
    {
        private readonly PlayerView _playerView;
        private readonly Transform _cameraTransform;
        private readonly CameraSettings _settings;

        public CameraMovementSystem(PlayerView playerView, Transform cameraTransform, CameraSettings settings)
        {
            _playerView = playerView;
            _cameraTransform = cameraTransform;
            _settings = settings;
        }

        public void Initialize()
        {
            _cameraTransform.eulerAngles = _settings.InitialRotation;
        }

        public void LateUpdate()
        {
            _cameraTransform.position = _settings.PositionOffset + _playerView.transform.position;
        }
    }
}