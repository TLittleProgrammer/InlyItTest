using UnityEngine;

namespace App.Scripts.InteractiveItems
{
    public sealed class InteractiveView : MonoBehaviour, IInteractiveItem
    {
        [SerializeField] private InteractiveType interactiveType;

        public InteractiveType InteractiveType => interactiveType;
    }
}