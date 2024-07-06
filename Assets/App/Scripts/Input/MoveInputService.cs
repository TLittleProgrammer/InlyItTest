using UnityEngine;

namespace App.Scripts.Input
{
    public abstract class MoveInputService : IMoveInputService
    {
        protected const string Horizontal = "Horizontal";
        protected const string Vertical = "Vertical";

        public abstract Vector3 Axis { get; }
    }
}