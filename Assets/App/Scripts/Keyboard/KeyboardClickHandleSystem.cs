using System;
using UnityEngine;

namespace App.Scripts.Keyboard
{
    public sealed class KeyboardClickHandleSystem : IKeyboardClickHandleSystem
    {
        public event Action KeyClicked;

        public void Update()
        {
            if (UnityEngine.Input.anyKeyDown)
            {
                KeyClicked?.Invoke();
            }
        }
    }
}