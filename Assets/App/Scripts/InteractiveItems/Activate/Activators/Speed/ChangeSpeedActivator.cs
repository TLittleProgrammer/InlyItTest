using App.Scripts.Player.Systems;

namespace App.Scripts.InteractiveItems.Activate.Activators.Speed
{
    public abstract class ChangeSpeedActivator : IInteractiveItemActivator
    {
        private readonly ChangeSpeedSettings _speedSettings;
        private readonly IPlayerMovementSystem _playerMovementSystem;

        protected ChangeSpeedActivator(ChangeSpeedSettings speedSettings, IPlayerMovementSystem playerMovementSystem)
        {
            _speedSettings = speedSettings;
            _playerMovementSystem = playerMovementSystem;
        }
        
        public virtual void Activate()
        {
            _playerMovementSystem.AddSpeed(_speedSettings.SpeedOffset);
        }
    }
}