namespace GraphicsTest;

public class ClockBuilder
{    
    public PointF Location => this.Rect.Center;
    private IList<IElement> Elements { get; set; }
    private RectF Rect { get;}
    private float MinSizeLength => 
        Math.Min(this.Rect.Width, this.Rect.Height);    

    public ClockBuilder(RectF rect)
    {       
        this.Rect     = rect;
        this.Elements = new List<IElement>();             
    }
   
    public ClockBuilder WithHands(TimeOnly time)
    {
        this.Elements.Add(new AccurateHourHand(time));
        this.Elements.Add(new MinuteHand(time));        
        this.Elements.Add(new SecondHand(time));
        return this;
    }
    public ClockBuilder WithFrame()
    {
        this.Elements.Add(new ClockFrame());
        return this;
    }

    public ClockBuilder WithSticks()
    {
        this.Elements.Add(new StickClock());
        return this;
    }   

    public void Draw(ICanvas canvas, float strokeSize, Color strokeColor)
    {      
        canvas.StrokeColor = Colors.Aqua;
        canvas.FillColor   = Colors.Aqua;
        canvas.StrokeSize = strokeSize / (this.MinSizeLength / 2);      

        canvas.Translate(this.Rect.Center.X, this.Rect.Center.Y);
        canvas.Scale(this.MinSizeLength/2, this.MinSizeLength/2);       

        foreach (var element in this.Elements)
            element.Draw(canvas);
    }

    
}
   


