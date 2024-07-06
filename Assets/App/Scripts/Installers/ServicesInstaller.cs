using App.Scripts.Input;
using App.Scripts.SceneContainer.Installer;
using App.Scripts.Time;

namespace App.Scripts.Installers
{
    public class ServicesInstaller : MonoInstaller
    {
        protected override void OnInstallBindings()
        {
            Container.SetService<ITimeProvider, TimeProvider>(new());
            Container.SetService<IMoveInputService, StandaloneMoveInputService>(new());
        }
    }
}