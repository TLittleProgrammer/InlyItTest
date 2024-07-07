using App.Scripts.Bootstrap.Effects;
using App.Scripts.SceneContainer.Installer;

namespace App.Scripts.Bootstrap.Installers
{
    public class EffectsInstaller : MonoInstaller
    {
        protected override void OnInstallBindings()
        {
            var effectsActivator = Container.CreateInstance<EffectsActivator>();
            
            Container.SetService<IEffectsActivator, EffectsActivator>(effectsActivator);
        }
    }
}