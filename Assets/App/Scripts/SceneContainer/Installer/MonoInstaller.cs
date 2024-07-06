using App.Scripts.SceneContainer.ServiceLocator;
using UnityEngine;

namespace App.Scripts.SceneContainer.Installer
{
    public abstract class MonoInstaller : MonoBehaviour
    {
        protected ServiceContainer Container { get; set; }

        public void InstallBindings(ServiceContainer serviceContainer)
        {
            Container = serviceContainer;
            OnInstallBindings();
        }
        protected abstract void OnInstallBindings();
    }
}