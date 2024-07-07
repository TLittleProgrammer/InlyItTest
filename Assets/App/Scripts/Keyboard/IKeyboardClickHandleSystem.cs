using System;
using App.Scripts.SceneContainer.Installer;

namespace App.Scripts.Keyboard
{
    public interface IKeyboardClickHandleSystem : IUpdatable
    {
        event Action KeyClicked;
    }
}