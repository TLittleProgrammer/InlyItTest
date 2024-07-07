namespace App.Scripts.SceneContainer.Installer
{
    public interface IInitializable
    {
        void Initialize()
        {
            
        }
    }

    public interface IInitializable<in T>
    {
        void Initialize(T value);
    }
}