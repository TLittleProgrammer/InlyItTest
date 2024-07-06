using App.Scripts.Constants;
using App.Scripts.Input;
using App.Scripts.Time;
using UnityEngine;

namespace App.Scripts.Player.Systems
{
    public class PlayerMovementSystem : IPlayerMovementSystem
    {
        private readonly PlayerView _playerView;
        private readonly IMoveInputService _moveInputService;
        private readonly Transform _cameraTransform;
        private readonly ITimeProvider _timeProvider;
        private readonly PlayerMovementSettings _movementSettings;

        public PlayerMovementSystem(
            PlayerView playerView,
            IMoveInputService moveInputService,
            Transform cameraTransform,
            ITimeProvider timeProvider,
            PlayerMovementSettings movementSettings)
        {
            _playerView = playerView;
            _moveInputService = moveInputService;
            _cameraTransform = cameraTransform;
            _timeProvider = timeProvider;
            _movementSettings = movementSettings;
        }

        public void UpdateModule()
        {
            Vector3 direction = GetDirection();

            _playerView.CharacterController.Move( direction * _movementSettings.Speed * _timeProvider.DeltaTime);
        }

        private Vector3 GetDirection()
        {
            Vector3 direction = Vector3.zero;

            if (_moveInputService.Axis.magnitude > MathConstants.Epsilon)
            {
                UpdateDirectionAndRotation(out direction);
            }

            direction += Physics.gravity;
            return direction;
        }

        private void UpdateDirectionAndRotation(out Vector3 direction)
        {
            direction = _cameraTransform.TransformDirection(_moveInputService.Axis);
            direction.y = 0f;
            direction.Normalize();

            _playerView.transform.forward = direction;
        }
    }
}