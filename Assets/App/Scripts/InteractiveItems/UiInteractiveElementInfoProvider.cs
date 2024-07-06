using System.Collections.Generic;
using UnityEngine;

namespace App.Scripts.InteractiveItems
{
    [CreateAssetMenu(menuName = "Configs/InteractiveElementInfoProvider", fileName = "InteractiveElementInfoProvider")]
    public class UiInteractiveElementInfoProvider : ScriptableObject
    {
        public List<InteractiveUiInfo> Info;
    }
}