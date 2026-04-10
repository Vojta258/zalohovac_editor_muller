using zalohovac_editor_muller.Entities;
using zalohovac_editor_muller.Presentation.Windows;

namespace zalohovac_editor_muller
{
    public class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();
            BackupJob backupJob = new BackupJob();
            BackupMethod backupMethod = new BackupMethod();
            BackupRetention backupRetention = new BackupRetention();

            IWindow window = new JsonSettingWindow(backupJob, backupMethod, backupRetention,app);
            app.Run(window);
            
        }
    }
}
