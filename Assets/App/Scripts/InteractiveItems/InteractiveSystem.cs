using System.Collections.Generic;
using App.Scripts.Player.Systems;

namespace App.Scripts.InteractiveItems
{
    public class InteractiveSystem : IInteractiveSystem
    {
        private readonly IUIInteractiveItemSystem _uiInteractiveItemSystem;
        private readonly List<IInteractiveItem> _interactiveItems = new();
        
        public InteractiveSystem(IUIInteractiveItemSystem uiInteractiveItemSystem)
        {
            _uiInteractiveItemSystem = uiInteractiveItemSystem;
        }
        
        public void EnterInteractive(IInteractiveItem interactiveItem)
        {
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