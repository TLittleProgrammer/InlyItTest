using App.Scripts.Installers;
using App.Scripts.Map;
using App.Scripts.SceneContainer.Installer;
using UnityEngine;

namespace App.Scripts.Bootstrap.Installers
{
    public class MapInstaller : MonoInstaller
    {
        [SerializeField] private PlaneMap _planeMap;
        [SerializeField] private MapSettings _mapSettings;
            
        protected override void OnInstallBindings()
        {
            Container.SetService<IMap, PlaneMap>(_planeMap);
            Container.SetService<MapSettings, MapSettings>(_mapSettings);
        }
    }
}