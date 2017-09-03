public class LightSoftwareComponent : SoftwareComponent
{
    private string type;

    public LightSoftwareComponent(string name, long capacityConsumption, long memoryConsumption)
        : base(name, capacityConsumption, memoryConsumption)
    {
    }

    public override long CapacityConsumption
    {
        get
        {
            return base.CapacityConsumption;
        }

        protected set
        {
            base.CapacityConsumption = value + value / 2;
        }
    }

    public override long MemoryConsumption
    {
        get
        {
            return base.MemoryConsumption;
        }

        protected set
        {
            base.MemoryConsumption = value - value / 2;
        }
    }
}
