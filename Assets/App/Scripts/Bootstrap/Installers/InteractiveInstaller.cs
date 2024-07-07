using System.Collections.Generic;
using App.Scripts.InteractiveItems;
using App.Scripts.InteractiveItems.Activate.Activators.Speed;
using App.Scripts.Player;
using App.Scripts.Player.Systems;
using App.Scripts.SceneContainer.Installer;
using UnityEngine;

namespace App.Scripts.Bootstrap.Installers
{
    public class InteractiveInstaller : MonoInstaller
    {
        [SerializeField] private InteractiveElement _interactivePrefab;
        [SerializeField] private Transform _interactiveParent;
        [SerializeField] private PlayerView _playerView;
        [SerializeField] private UiInteractiveElementInfoProvider _uiInteractiveElementInfoProvider;
        [SerializeField] private ChangeHealthSettings _medicineChestSettings;
        [SerializeField] private ChangeHealthSettings _getDamageSettings;
        [SerializeField] private ChangeSpeedSettings _addSpeedSettings;
        [SerializeField] private ChangeSpeedSettings _minusSpeedSettings;
        
        protected override void OnInstallBindings()
        {
            Container.SetService<UiInteractiveElementInfoContainer, UiInteractiveElementInfoContainer>(new(_uiInteractiveElementInfoProvider));
            
            UIInteractiveItemSystem system = Container.CreateInstanceWithArguments<UIInteractiveItemSystem>(_interactivePrefab, _interactiveParent);
            Container.SetService<IUIInteractiveItemSystem, UIInteractiveItemSystem>(system);

            InteractiveSystem interactiveSystem = Container.CreateInstance<InteractiveSystem>();
            Container.SetServiceInterfaces(interactiveSystem);

            List<InteractiveItemActivatorInfo> activatorsInfo = CreateListActivatorsInfo();
            
            InteractiveItemsActivator interactiveItemsActivator = Container.CreateInstanceWithArguments<InteractiveItemsActivator>(activatorsInfo);
            Container.SetServiceInterfaces(interactiveItemsActivator);
            
            
            PlayerCollisionSystem playerCollisionSystem = CreatePlayerCollisionSystem(interactiveSystem);
            Container.SetServiceInterfaces(playerCollisionSystem);
        }

        private List<InteractiveItemActivatorInfo> CreateListActivatorsInfo()
        {
            List<InteractiveItemActivatorInfo> interactiveItemActivators = new();
            
            var medicineChestActivator = Container.CreateInstanceWithArguments<MedicineChestActivator>(_medicineChestSettings);
            var getDamageActivator     = Container.CreateInstanceWithArguments<GetDamageActivator>(_getDamageSettings);
            var addSpeedActivator      = Container.CreateInstanceWithArguments<AddSpeedActivator>(_addSpeedSettings);
            var minusSpeedActivator    = Container.CreateInstanceWithArguments<MinusSpeedActivator>(_minusSpeedSettings);

            AddItem(interactiveItemActivators, InteractiveType.MedicineChest, medicineChestActivator);
            AddItem(interactiveItemActivators, InteractiveType.GetDamage, getDamageActivator);
            AddItem(interactiveItemActivators, InteractiveType.AddSpeed, addSpeedActivator);
            AddItem(interactiveItemActivators, InteractiveType.MinusSpeed, minusSpeedActivator);

            return interactiveItemActivators;
        }

        private void AddItem(List<InteractiveItemActivatorInfo> interactiveItemActivators, InteractiveType type, IInteractiveItemActivator activator)
        {
            interactiveItemActivators.Add(new()
            {
                Id = type,
                Activator = activator
            });
        }
        
        private PlayerCollisionSystem CreatePlayerCollisionSystem(IInteractiveSystem interactiveSystem)
        {
            return Container.CreateInstanceWithArguments<PlayerCollisionSystem>(_playerView, interactiveSystem);
        }
    }
}