namespace App.Scripts.InteractiveItems
{
    public abstract class ChangeHealthActivator : IInteractiveItemActivator
    {
        private readonly ChangeHealthSettings _healthSettings;
        private readonly IHealthSystem _healthSystem;

        protected ChangeHealthActivator(ChangeHealthSettings healthSettings, IHealthSystem healthSystem)
        {
            _healthSettings = healthSettings;
            _healthSystem = healthSystem;
        }
        
        public virtual void Activate()
        {
            _healthSystem.ChangeHealth(_healthSettings.HealthOffset);
        }
    }
}