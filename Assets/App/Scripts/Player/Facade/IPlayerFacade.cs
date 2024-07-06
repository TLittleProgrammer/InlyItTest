using App.Scripts.SceneContainer.Installer;

namespace App.Scripts.Player.Facade
{
    public interface IPlayerFacade : IUpdatable
    {
        void AddModule(IPlayerModule playerModule);
        void RemoveModule(IPlayerModule playerModule);
    }
}