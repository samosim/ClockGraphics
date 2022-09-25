namespace GraphicsTest;

public class SecondHand : ClockHand
{
    public SecondHand(TimeOnly time)
        : base(time)
    {
    }
    public override float Angle => this.Time.Second * 360f / 60;

    public override float UnitLength =>
        base.UnitLength * (float) 0.8;
}
   


