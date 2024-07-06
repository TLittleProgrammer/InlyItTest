using UnityEngine;

namespace App.Scripts.InteractiveItems
{
    public sealed class InteractiveView : MonoBehaviour, IInteractiveItem
    {
        [SerializeField] private InteractiveType _interactiveType;

        public InteractiveType InteractiveType => _interactiveType;
    }
}