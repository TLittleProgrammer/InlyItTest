using System.Collections.Generic;
using System.Linq;

namespace App.Scripts.InteractiveItems
{
    public sealed class UiInteractiveElementInfoContainer
    {
        public Dictionary<InteractiveType,InteractiveUiInfo> Info { get; }

        public UiInteractiveElementInfoContainer(UiInteractiveElementInfoProvider infoProvider)
        {
            Info = infoProvider
                .Info
                .ToDictionary(x => x.Id, x => x);
        }
    }
}