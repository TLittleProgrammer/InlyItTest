using UnityEngine;

namespace App.Scripts.Input
{
    public class StandaloneMoveInputService : MoveInputService
    {
        public override Vector3 Axis => 
            new(UnityEngine.Input.GetAxis(Horizontal), 0f, UnityEngine.Input.GetAxis(Vertical));
    }
}