using System.Collections.Generic;

namespace App.Scripts.SceneContainer.ServiceLocator
{
    public interface IServiceContainer
    {
        object GetValue();
        IEnumerable<object> GetValues();
    }
}