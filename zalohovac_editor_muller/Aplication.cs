
using zalohovac_editor_muller.Presentation.Windows;

namespace zalohovac_editor_muller
{
    public class Aplication
    {
        private bool _running;
        private IWindow? _activeWindow;

        public Aplication()
        {
            _running = false;
            _activeWindow = null;
        }

        public void Run(IWindow window)
        {
            _running = true;
            _activeWindow = window;
        }
    }
}
