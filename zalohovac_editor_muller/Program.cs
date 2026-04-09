using zalohovac_editor_muller.Presentation.Windows;

namespace zalohovac_editor_muller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();

            IWindow window = new JsonSettingWindow();
            app.Run(window);
            
        }
    }
}
