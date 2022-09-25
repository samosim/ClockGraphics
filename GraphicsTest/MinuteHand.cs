namespace GraphicsTest;

public class MinuteHand : ClockHand
{
    public MinuteHand(TimeOnly time)
        : base(time)
    {
    }
    public override float Angle => this.Time.Minute * 360f / 60;
    public override float UnitLength =>
       base.UnitLength * 0.8f;
}
   


