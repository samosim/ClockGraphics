namespace GraphicsTest;

public class StickClock : IElement
{   
    private float StickLength => 0.1f;
    public float UnitLength => 1;
    public StickClock()
    {        
    }
    public void Draw(ICanvas canvas)
    {       
        canvas.SaveState();        
              
        for (int i = 6; i <= 360; i = i + 6)
        {            
            canvas.Rotate(6);
            PointF point = new PointF(0, - this.UnitLength + this.StickLength / 2);            
            canvas.DrawLine(point, point.Offset(0, i%30 == 0 ? -this.StickLength: -this.StickLength/2));            
        }
        canvas.RestoreState();
    }
}
   


