using App.Scripts.InteractiveItems;
using App.Scripts.InteractiveItems.UI;
using App.Scripts.SceneContainer.Installer;

namespace App.Scripts.Bootstrap.Installers
{
    public class HealthSystemInstaller : MonoInstaller
    {
        protected override void OnInstallBindings()
        {
            var healthSystem = Container.CreateInstance<HealthSystem>();
            
            Container.SetService<IHealthSystem, HealthSystem>(healthSystem);

            var model     = Container.CreateInstance<HealthModel>();
            var viewModel = Container.CreateInstanceWithArguments<HealthViewModel>(model);
            
            Container.SetServiceInterfaces(model);
            Container.SetServiceInterfaces(viewModel);
            
            Container.SetService<HealthViewModel, HealthViewModel>(viewModel);
        }
    }
}