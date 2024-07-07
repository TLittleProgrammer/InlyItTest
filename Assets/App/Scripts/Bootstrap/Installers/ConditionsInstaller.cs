using System;
using System.Collections.Generic;
using App.Scripts.InteractiveItems;
using App.Scripts.InteractiveItems.Activate.Activators.Speed;
using App.Scripts.InteractiveItems.Conditions;
using App.Scripts.Player.Systems;
using App.Scripts.SceneContainer.Installer;
using App.Scripts.Settings;
using UnityEngine;

namespace App.Scripts.Bootstrap.Installers
{
    public class ConditionsInstaller : MonoInstaller
    {
        [SerializeField] private GameSettings _gameSettings;
        [SerializeField] private ChangeHealthSettings _addHealthSettings;
        [SerializeField] private ChangeSpeedSettings _minusSpeedSettings;
        
        protected override void OnInstallBindings()
        {
            List<IntarectiveItemConditionInfo> conditions = CreateConditions();
            
            var canUseItemResolveSystem = Container.CreateInstanceWithArguments<CanUseItemResolveSystem>(conditions);
            
            Container.SetService<ICanUseItemResolveSystem, CanUseItemResolveSystem>(canUseItemResolveSystem);
        }

        private List<IntarectiveItemConditionInfo> CreateConditions()
        {
            List<IntarectiveItemConditionInfo> conditions = new();

            IHealthSystem healthSystem = Container.Get<IHealthSystem>();
            IPlayerMovementSystem playerMovementSystem = Container.Get<IPlayerMovementSystem>();
            
            conditions.Add(CreateHealthCondition(InteractiveType.MedicineChest, () => healthSystem.CurrentHealth + _addHealthSettings.HealthOffset <= _gameSettings.MaxHealth));
            conditions.Add(CreateHealthCondition(InteractiveType.GetDamage, () => healthSystem.CurrentHealth > 0));
            conditions.Add(CreateHealthCondition(InteractiveType.MinusSpeed, () => playerMovementSystem.CurrentSpeed + _minusSpeedSettings.SpeedOffset >= _gameSettings.MinSpeed));
            
            return conditions;
        }

        private IntarectiveItemConditionInfo CreateHealthCondition(InteractiveType interactiveType, Func<bool> condition)
        {
            SimpleCondition simpleCondition = new(condition);

            return new()
            {
                Id = interactiveType,
                Condition = simpleCondition
            };
        }
    }
}