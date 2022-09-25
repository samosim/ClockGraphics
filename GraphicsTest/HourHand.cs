namespace GraphicsTest;

public class HourHand : ClockHand
{
    public HourHand(TimeOnly time)
        : base(time)
    {
    }
    public override float Angle => 
        this.Time.Hour * 360f / 12;

    public override float UnitLength =>
       base.UnitLength * 0.6f;
}
   


