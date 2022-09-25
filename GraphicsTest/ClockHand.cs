namespace GraphicsTest;

public abstract class ClockHand : IElement
{   
    public TimeOnly Time { get; }
    public abstract float Angle { get; }
    public virtual float UnitLength => 1;

    public ClockHand(TimeOnly time)
    {
        this.Time = time;       
    }

    public virtual void Draw(ICanvas canvas)
    {
        canvas.SaveState();
        canvas.StrokeLineCap = LineCap.Round;
        canvas.Rotate(this.Angle, 0, 0);        
        canvas.DrawLine(0, 0, 0, -this.UnitLength);
        canvas.RestoreState();
    }

}
   


