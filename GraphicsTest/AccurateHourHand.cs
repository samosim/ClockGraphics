namespace GraphicsTest;

public class AccurateHourHand : ClockHand
{
    public AccurateHourHand(TimeOnly time)
        : base(time)
    {
    }
    public override float Angle => 
        (this.Time.Hour + this.Time.Minute / 60f) * 360f / 12;

    public override float UnitLength =>
      base.UnitLength * 0.6f;
}
   


