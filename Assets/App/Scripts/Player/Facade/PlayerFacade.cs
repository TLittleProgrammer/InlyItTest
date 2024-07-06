using System.Collections.Generic;
using UnityEngine;

namespace App.Scripts.Player.Facade
{
    public sealed class PlayerFacade : IPlayerFacade
    {
        private readonly List<IPlayerModule> _modules = new();
        
        public void Update()
        {
            foreach (IPlayerModule module in _modules)
            {
                module.UpdateModule();
            }
        }

        public void AddModule(IPlayerModule playerModule)
        {
            _modules.Add(playerModule);
        }

        public void RemoveModule(IPlayerModule playerModule)
        {
            _modules.Remove(playerModule);
        }
    }
}