using System;
using System.Drawing;
using System.Windows.Forms;

namespace DuplicatedFiles
{
    public enum ProgressBarDisplayText
    {
        Percentage,
        CustomText
    }

    public partial class InfoProgressBar : ProgressBar
    {
        //Property to set to decide whether to print a % or Text
        public ProgressBarDisplayText DisplayStyle { get; set; }

        //Property to hold the custom text
        public string CustomText { get; set; }

        public InfoProgressBar()
        {
            // Modify the ControlStyles flags
            //http://msdn.microsoft.com/en-us/library/system.windows.forms.controlstyles.aspx
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var rect = ClientRectangle;
            var g = e.Graphics;

            ProgressBarRenderer.DrawHorizontalBar(g, rect);
            rect.Inflate(-3, -3);
            if (Value > 0)
            {
                // As we doing this ourselves we need to draw the chunks on the progress bar
                var clip = new Rectangle(rect.X, rect.Y, (int) Math.Round(((float) Value / Maximum) * rect.Width),
                    rect.Height);
                ProgressBarRenderer.DrawHorizontalChunks(g, clip);
            }

            // Set the Display text (Either a % amount or our custom text
            var text = CustomText;

            if (DisplayStyle == ProgressBarDisplayText.Percentage && Maximum != 0)
            {
                text = (100 / (decimal) Maximum * Value / 100).ToString("P");
            }


            var len = g.MeasureString(text, Font);
            // Calculate the location of the text (the middle of progress bar)
            // Point location = new Point(Convert.ToInt32((rect.Width / 2) - (len.Width / 2)), Convert.ToInt32((rect.Height / 2) - (len.Height / 2)));
            var location = new Point(Convert.ToInt32((Width / 2) - len.Width / 2),
                Convert.ToInt32((Height / 2) - len.Height / 2));
            // The commented-out code will centre the text into the highlighted area only. This will centre the text regardless of the highlighted area.
            // Draw the custom text
            g.DrawString(text, Font, Brushes.Black, location);
        }
    }
}
