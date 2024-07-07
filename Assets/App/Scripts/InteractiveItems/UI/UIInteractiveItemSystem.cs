using System;
using System.Collections.Generic;
using App.Scripts.Player.Systems;
using UnityEngine;
using Object = UnityEngine.Object;

namespace App.Scripts.InteractiveItems
{
    public sealed class UIInteractiveItemSystem : IUIInteractiveItemSystem
    {
        private readonly Transform _interactiveElementsParent;
        private readonly UiInteractiveElementInfoContainer _infoContainer;
        private readonly InteractiveElement _interactiveElementPrefab;
        private readonly Dictionary<InteractiveType, InteractiveElement> _activeElements = new();

        public UIInteractiveItemSystem(
            InteractiveElement interactiveElement,
            Transform elementsParent, 
            UiInteractiveElementInfoContainer infoContainer)
        {
            _interactiveElementPrefab = interactiveElement;
            _interactiveElementsParent = elementsParent;
            _infoContainer = infoContainer;
        }

        public void AddItem(InteractiveType interactiveItemType)
        {
            if (IsInteractiveItemActive(interactiveItemType))
            {
                return;
            }

            var element = CreateInteractiveElement(interactiveItemType);

            _activeElements.Add(interactiveItemType, element);
        }

        public void RemoveItem(InteractiveType interactiveItemType)
        {
            if (IsInteractiveItemActive(interactiveItemType) && _activeElements[interactiveItemType] is not null)
            {
                Object.Destroy(_activeElements[interactiveItemType].gameObject);
                _activeElements.Remove(interactiveItemType);
            }
        }

        private InteractiveElement CreateInteractiveElement(InteractiveType interactiveItemType)
        {
            InteractiveElement element = InstantiateInteractiveElement();
            element.ElementName.text = _infoContainer.Info[interactiveItemType].Naming;
            return element;
        }

        private bool IsInteractiveItemActive(InteractiveType interactiveItemType)
        {
            return _activeElements.ContainsKey(interactiveItemType);
        }

        private InteractiveElement InstantiateInteractiveElement()
        {
            return Object.Instantiate(_interactiveElementPrefab, _interactiveElementsParent);
        }
    }
}