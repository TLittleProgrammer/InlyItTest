using App.Scripts.InteractiveItems.UI;
using App.Scripts.SceneContainer.Installer;

namespace App.Scripts.Bootstrap.EntryPoints
{
    public class HealthInitializer : IInitializable
    {
        private readonly HealthViewModel _healthViewModel;
        private readonly HealthView _healthView;

        public HealthInitializer(HealthViewModel healthViewModel, HealthView healthView)
        {
            _healthViewModel = healthViewModel;
            _healthView = healthView;
        }

        public void Initialize()
        {
            _healthView.Initialize(_healthViewModel);
        }
    }
}