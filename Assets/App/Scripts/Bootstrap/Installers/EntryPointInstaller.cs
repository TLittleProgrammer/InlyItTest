using App.Scripts.Bootstrap.EntryPoints;
using App.Scripts.SceneContainer.Installer;
using App.Scripts.Walls;
using UnityEngine;

namespace App.Scripts.Bootstrap.Installers
{
    public class EntryPointInstaller : MonoInstaller
    {
        [SerializeField] private WallView _wallPrefab;
        [SerializeField] private Transform _wallParent;
        
        protected override void OnInstallBindings()
        {
            var mapInitializer = Container.CreateInstance<MapInitializer>();
            var wallInitializer = Container.CreateInstanceWithArguments<WallsInitializer>(_wallPrefab, _wallParent);
            
            Container.SetService<IInitializable, MapInitializer>(mapInitializer);
            Container.SetService<IInitializable, WallsInitializer>(wallInitializer);
        }
    }
}