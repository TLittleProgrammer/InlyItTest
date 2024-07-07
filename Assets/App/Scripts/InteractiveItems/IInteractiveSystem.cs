namespace App.Scripts.InteractiveItems
{
    public interface IInteractiveSystem
    {
        void EnterInteractive(IInteractiveItem interactiveItem);
        void ExitInteractive(IInteractiveItem interactiveItem);

        InteractiveType GetInteractiveTypeThatNeedUse();
    }
}