using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempName
{
    public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Create a GraphicsPath object to define the button's shape.
            GraphicsPath graphicsPath = new GraphicsPath();

            // Set the button's shape to an ellipse (circle) using the Width and Height of the button.
            graphicsPath.AddEllipse(4, 4, ClientSize.Width - 8, ClientSize.Height - 8);

            // Set the button's region to be the circular path we defined.
            this.Region = new Region(graphicsPath);

            // Call the base class's OnPaint to draw the button.
            base.OnPaint(pevent);
        }
    }
}
