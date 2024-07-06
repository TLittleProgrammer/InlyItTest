using System;
using App.Scripts.InteractiveItems;
using App.Scripts.Player.Systems;
using App.Scripts.SceneContainer.Installer;
using UnityEngine;

namespace App.Scripts.Bootstrap.Installers
{
    public class InteractiveInstaller : MonoInstaller
    {
        [SerializeField] private InteractiveElement _interactivePrefab;
        [SerializeField] private Transform _interactiveParent;
        [SerializeField] private UiInteractiveElementInfoProvider _uiInteractiveElementInfoProvider;
        
        protected override void OnInstallBindings()
        {
            Container.SetService<UiInteractiveElementInfoContainer, UiInteractiveElementInfoContainer>(new(_uiInteractiveElementInfoProvider));
            
            
            UIInteractiveItemSystem system = Container.CreateInstanceWithArguments<UIInteractiveItemSystem>(_interactivePrefab, _interactiveParent);
            Container.SetService<IUIInteractiveItemSystem, UIInteractiveItemSystem>(system);
        }
    }
}