using App.Scripts.Keyboard;
using App.Scripts.SceneContainer.Installer;

namespace App.Scripts.Bootstrap.Installers
{
    public class KeyboardInstaller : MonoInstaller
    {
        protected override void OnInstallBindings()
        {
            KeyboardClickHandleSystem system = new KeyboardClickHandleSystem();
            
            Container.SetServiceInterfaces(system);
        }
    }
}