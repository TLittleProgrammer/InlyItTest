using App.Scripts.Player.Facade;
using App.Scripts.SceneContainer.Installer;

namespace App.Scripts.Player.Systems
{
    public interface IPlayerMovementSystem : IPlayerModule
    {
        float CurrentSpeed { get; }
        void AddSpeed(float speed);
    }
}