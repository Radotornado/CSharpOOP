public class PowerHardwareComponent : HardwareComponent
{
    private string type;

    public PowerHardwareComponent(string name, long maximumCapacity, long maximumMemory)
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
            base.MaximumCapacity = value - ((value * 3) / 4);
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
            base.MaximumMemory = value + (value * 3) / 4;
        }
    }
}
