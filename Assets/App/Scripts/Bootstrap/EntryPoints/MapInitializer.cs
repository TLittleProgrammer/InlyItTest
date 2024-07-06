using App.Scripts.Installers;
using App.Scripts.Map;
using App.Scripts.SceneContainer.Installer;

namespace App.Scripts.Bootstrap.EntryPoints
{
    public class MapInitializer : IInitializable
    {
        private readonly IMap _map;
        private readonly MapSettings _mapSettings;

        public MapInitializer(IMap map, MapSettings mapSettings)
        {
            _map = map;
            _mapSettings = mapSettings;
        }

        public void Initialize()
        {
            _map.ChangeMapScale(_mapSettings.InitialScale);
        }
    }
}