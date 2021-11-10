namespace Manufaktura.Controls.Model.Misc
{
    public struct VerticalBounds
    {
        public VerticalBounds(double upper, double lower)
        {
            Upper = upper;
            Lower = lower;
        }

        public double Lower { get; }
        public double Upper { get; }
    }
}