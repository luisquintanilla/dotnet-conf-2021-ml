using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;

namespace Manufaktura.Controls.Model
{
    public interface ICanCalculateRenderedBounds
    {
        Quadrangle GetBounds(ScoreRendererBase renderer);
    }
}