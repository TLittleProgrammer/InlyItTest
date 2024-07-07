using System.Collections.Generic;
using App.Scripts.Player.Systems;
using Unity.VisualScripting;

namespace App.Scripts.InteractiveItems
{
    public class InteractiveSystem : IInteractiveSystem
    {
        private readonly IUIInteractiveItemSystem _uiInteractiveItemSystem;
        private readonly List<IInteractiveItem> _interactiveItems = new();
        private readonly ICanUseItemResolveSystem _canUseItemResolveSystem;

        public InteractiveSystem(IUIInteractiveItemSystem uiInteractiveItemSystem, ICanUseItemResolveSystem canUseItemResolveSystem)
        {
            _uiInteractiveItemSystem = uiInteractiveItemSystem;
            _canUseItemResolveSystem = canUseItemResolveSystem;
        }
        
        public void EnterInteractive(IInteractiveItem interactiveItem)
        {
            if (!_canUseItemResolveSystem.CanUseItItem(interactiveItem))
            {
                return;
            }

            _uiInteractiveItemSystem.AddItem(interactiveItem.InteractiveType);
            
            _interactiveItems.Add(interactiveItem);
        }

        public void ExitInteractive(IInteractiveItem interactiveItem)
        {
            _uiInteractiveItemSystem.RemoveItem(interactiveItem.InteractiveType);
            
            _interactiveItems.Remove(interactiveItem);
        }

        public InteractiveType GetInteractiveTypeThatNeedUse()
        {
            return _interactiveItems.Count == 0 ? InteractiveType.None : _interactiveItems[0].InteractiveType;
        }
    }
}