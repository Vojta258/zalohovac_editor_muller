using static System.Net.Mime.MediaTypeNames;

namespace zalohovac_editor_muller.Presentation.Windows
{
    internal class BaseWindow :IWindow
    {
        public event Action? Closed;
        public event Action? Submitted;

        protected string _title;
        protected Application _application;
        protected IWindow? _returnWindow;

        private List<IComponent> _components;
        private int _selectedIndex;
    }
}
