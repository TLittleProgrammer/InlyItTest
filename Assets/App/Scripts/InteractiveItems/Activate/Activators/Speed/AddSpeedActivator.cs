using App.Scripts.Player.Systems;

namespace App.Scripts.InteractiveItems.Activate.Activators.Speed
{
    public class AddSpeedActivator : ChangeSpeedActivator
    {
        public AddSpeedActivator(ChangeSpeedSettings speedSettings, IPlayerMovementSystem playerMovementSystem) : base(speedSettings, playerMovementSystem)
        {
        }
    }
}