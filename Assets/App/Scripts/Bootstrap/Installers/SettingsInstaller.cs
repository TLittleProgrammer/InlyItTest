using App.Scripts.SceneContainer.Installer;
using App.Scripts.Settings;
using UnityEngine;

namespace App.Scripts.Bootstrap.Installers
{
    public class SettingsInstaller : MonoInstaller
    {
        [SerializeField] private GameSettings _gameSettings;
        
        protected override void OnInstallBindings()
        {
            Container.SetService<GameSettings, GameSettings>(_gameSettings);
        }
    }
}