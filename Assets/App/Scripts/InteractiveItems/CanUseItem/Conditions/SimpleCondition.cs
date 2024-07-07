using System;
using App.Scripts.Settings;

namespace App.Scripts.InteractiveItems.Conditions
{
    public class SimpleCondition : IIntarectiveCondition
    {
        private readonly Func<bool> _condition;

        public SimpleCondition(Func<bool> condition)
        {
            _condition = condition;
        }
        
        public bool Check()
        {
            return _condition.Invoke();
        }
    }
}