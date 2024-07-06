using App.Scripts.Player.Systems;

namespace App.Scripts.InteractiveItems
{
    public class InteractiveSystem : IInteractiveSystem
    {
        private readonly IUIInteractiveItemSystem _uiInteractiveItemSystem;

        public InteractiveSystem(IUIInteractiveItemSystem uiInteractiveItemSystem)
        {
            _uiInteractiveItemSystem = uiInteractiveItemSystem;
        }
        
        public void EnterInteractive(IInteractiveItem interactiveItem)
        {
            _uiInteractiveItemSystem.AddItem(interactiveItem.InteractiveType);
        }

        public void ExitInteractive(IInteractiveItem interactiveItem)
        {
            _uiInteractiveItemSystem.RemoveItem(interactiveItem.InteractiveType);
        }
    }
}