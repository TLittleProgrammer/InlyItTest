using App.Scripts.Player.Systems;

namespace App.Scripts.InteractiveItems.Activate.Activators.Speed
{
    public class MinusSpeedActivator : ChangeSpeedActivator
    {
        public MinusSpeedActivator(ChangeSpeedSettings speedSettings, IPlayerMovementSystem playerMovementSystem) : base(speedSettings, playerMovementSystem)
        {
        }
    }
}