namespace GraphicsTest;

public class ClockFrame: IElement
{  
    public float UnitLength => 1;

    public void Draw(ICanvas canvas)
    {
        canvas.DrawCircle(0, 0, this.UnitLength);
        canvas.FillCircle(0, 0, this.UnitLength * 0.03f);
    }
}
   


