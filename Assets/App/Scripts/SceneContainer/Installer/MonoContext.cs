using System.Collections.Generic;
using App.Scripts.SceneContainer.ServiceLocator;
using UnityEngine;

namespace App.Scripts.SceneContainer.Installer
{
    public class MonoContext : MonoBehaviour
    {
        public List<MonoInstaller> Installers = new();

        private readonly List<IInitializable> _initializables = new();
        private readonly List<IUpdatable> _updatables = new();
        private readonly List<ILateUpdatable> _lateUpdatables = new();

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
            _lateUpdatables.AddRange(container.GetServices<ILateUpdatable>());
        }

        private ServiceContainer BuildContainer()
        {
            var container = new ServiceContainer();
            foreach (var installer in Installers)
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
        
        private void LateUpdate()
        {
            foreach (var lateUpdatable in _lateUpdatables)
            {
                lateUpdatable.LateUpdate();
            }
        }
    }
}