
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsTest;

public class ClockDrawable : IDrawable
{
    public float StrokeSize { get; set; } = 4;
    public Color StrokeColor { get; set; } = Colors.Aqua;   
    private TimeOnly TimeOnly =>
        TimeOnly.FromDateTime(DateTime.Now);
    public void Draw(ICanvas canvas, RectF dirtyRect) =>
        new ClockBuilder(dirtyRect)
            .WithFrame()
            .WithSticks()
            .WithHands(TimeOnly)            
            .Draw(canvas, StrokeSize, StrokeColor);    
                     
    
}
   


