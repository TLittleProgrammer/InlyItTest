using App.Scripts.Bootstrap.EntryPoints;
using App.Scripts.InteractiveItems.UI;
using App.Scripts.SceneContainer.Installer;
using App.Scripts.Walls;
using UnityEngine;

namespace App.Scripts.Bootstrap.Installers
{
    public class EntryPointInstaller : MonoInstaller
    {
        [SerializeField] private WallView _wallPrefab;
        [SerializeField] private Transform _wallParent;
        [SerializeField] private HealthView _healthView;
        
        protected override void OnInstallBindings()
        {
            var mapInitializer = Container.CreateInstance<MapInitializer>();
            var wallInitializer = Container.CreateInstanceWithArguments<WallsInitializer>(_wallPrefab, _wallParent);
            var healthInitializer = Container.CreateInstanceWithArguments<HealthInitializer>(_healthView);
            
            Container.SetService<IInitializable, MapInitializer>(mapInitializer);
            Container.SetService<IInitializable, WallsInitializer>(wallInitializer);
            Container.SetService<IInitializable, HealthInitializer>(healthInitializer);
        }
    }
}