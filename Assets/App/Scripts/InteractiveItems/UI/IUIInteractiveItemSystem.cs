using App.Scripts.InteractiveItems;

namespace App.Scripts.Player.Systems
{
    public interface IUIInteractiveItemSystem
    {
        void AddItem(InteractiveType interactiveItem);
        void RemoveItem(InteractiveType interactiveItem);
    }
}