using System.Collections.Generic;
using System.Linq;

namespace App.Scripts.InteractiveItems
{
    public sealed class CanUseItemResolveSystem : ICanUseItemResolveSystem
    {
        private readonly List<IntarectiveItemConditionInfo> _interactiveItemConditionInfos;

        public CanUseItemResolveSystem(List<IntarectiveItemConditionInfo> interactiveItemConditionInfos)
        {
            _interactiveItemConditionInfos = interactiveItemConditionInfos;
        }
        
        public bool CanUseItItem(InteractiveType type)
        {
            IntarectiveItemConditionInfo info = _interactiveItemConditionInfos.FirstOrDefault(x => x.Id == type);

            if (info is null)
            {
                return true;
            }

            return info.Condition.Check();
        }
    }
}