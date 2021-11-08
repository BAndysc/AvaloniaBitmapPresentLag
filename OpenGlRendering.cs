using Avalonia.OpenGL;
using Avalonia.OpenGL.Controls;
using Avalonia.Threading;
using static Avalonia.OpenGL.GlConsts;

namespace AvaloniaLag
{
    public class OpenGlRendering : MeasureOpenGlControlBase
    {
        protected override void OnOpenGlRender(GlInterface gl, int fb)
        {
            gl.Viewport(0, 0, (int)Bounds.Width, (int)Bounds.Height);
            gl.ClearColor(1, 1, 0, 1);
            gl.Clear(GL_COLOR_BUFFER_BIT);

            Dispatcher.UIThread.Post(InvalidateVisual, DispatcherPriority.Render);
        }
    }
}