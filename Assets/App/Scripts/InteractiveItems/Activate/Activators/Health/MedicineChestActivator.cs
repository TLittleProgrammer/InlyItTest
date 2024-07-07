namespace App.Scripts.InteractiveItems
{
    public sealed class MedicineChestActivator : ChangeHealthActivator
    {
        public MedicineChestActivator(ChangeHealthSettings healthSettings, IHealthSystem healthSystem) : base(healthSettings, healthSystem)
        {
        }
    }
}