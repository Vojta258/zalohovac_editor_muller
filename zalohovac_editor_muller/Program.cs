using zalohovac_editor_muller.Entities;
using zalohovac_editor_muller.Presentation.Windows;

namespace zalohovac_editor_muller
{
    public class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();


            IWindow window = new MainMenu(app);
            app.Run(window);
            
        }
    }
}
