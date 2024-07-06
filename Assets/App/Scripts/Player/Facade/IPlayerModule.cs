using App.Scripts.SceneContainer.Installer;

namespace App.Scripts.Player.Facade
{
    public interface IPlayerModule : IInitializable
    {
        void UpdateModule();
    }
}