using System.Collections.Generic;
using App.Scripts.SceneContainer.ServiceLocator;
using UnityEngine;

namespace App.Scripts.SceneContainer.Installer
{
    public class MonoContext : MonoBehaviour
    {
        public List<MonoInstaller> installers = new();

        private readonly List<IInitializable> _initializables = new();
        private readonly List<IUpdatable> _updatables = new();

        private void Start()
        {
            Setup();
            Init();
        }

        private void Setup()
        {
            var container = BuildContainer();
            _initializables.AddRange(container.GetServices<IInitializable>());
            _updatables.AddRange(container.GetServices<IUpdatable>());
        }

        private ServiceContainer BuildContainer()
        {
            var container = new ServiceContainer();
            foreach (var installer in installers)
            {
                installer.InstallBindings(container);
            }

            return container;
        }

        private void Init()
        {
            foreach (var initializable in _initializables)
            {
                initializable.Initialize();
            }
        }
        
        private void Update()
        {
            foreach (var updatable in _updatables)
            {
                updatable.Update();
            }
        }
    }
}