using System.Collections.Generic;
using System.Linq;
using App.Scripts.Bootstrap.Installers;
using App.Scripts.Keyboard;
using UnityEngine;

namespace App.Scripts.InteractiveItems
{
    public sealed class InteractiveItemsActivator : IInteractiveItemsActivator
    {
        private readonly IKeyboardClickHandleSystem _keyboardClickHandleSystem;
        private readonly IInteractiveSystem _interactiveSystem;
        private readonly List<InteractiveItemActivatorInfo> _activators;

        public InteractiveItemsActivator(
            IKeyboardClickHandleSystem keyboardClickHandleSystem,
            IInteractiveSystem interactiveSystem,
            List<InteractiveItemActivatorInfo> activators)
        {
            _keyboardClickHandleSystem = keyboardClickHandleSystem;
            _interactiveSystem = interactiveSystem;
            _activators = activators;
        }
        
        public void Initialize()
        {
            _keyboardClickHandleSystem.KeyClicked += Activate;
        }

        public void Activate()
        {
            InteractiveType needUseType = _interactiveSystem.GetInteractiveTypeThatNeedUse();
            
            if (IsCannotActivateInteractiveItem(needUseType))
                return;
            
            _activators.First(x => x.Id == needUseType).Activator.Activate();
        }

        private static bool IsCannotActivateInteractiveItem(InteractiveType needUseType)
        {
            return !UnityEngine.Input.GetKeyDown(KeyCode.E) || needUseType is InteractiveType.None;
        }
    }
}