public class HeavyHardwareComponent : HardwareComponent
{
    private string type;

    public HeavyHardwareComponent(string name, long maximumCapacity, long maximumMemory)
        : base(name, maximumCapacity, maximumMemory)
    {
        this.MaximumCapacity = maximumCapacity;
        this.MaximumMemory = maximumMemory;
    }

    public override long MaximumCapacity
    {
        get
        {
            return base.MaximumCapacity;
        }

        protected set
        {
            base.MaximumCapacity = value * 2;
        }
    }

    public override long MaximumMemory
    {
        get
        {
            return base.MaximumMemory;
        }

        protected set
        {
            base.MaximumMemory = value - value / 4;
        }
    }
}
