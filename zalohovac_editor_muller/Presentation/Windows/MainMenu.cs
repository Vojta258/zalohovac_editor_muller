using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zalohovac_editor_muller.Entities;
using zalohovac_editor_muller.Presentation.Components;

namespace zalohovac_editor_muller.Presentation.Windows
{
    public class MainMenu : BaseWindow
    {
    

        //IWindow window = new JsonSettingWindow(backupJob, backupMethod, backupRetention, app);

        private Button _createJsonButton;
        private Button _loadJsonButton;
        private Button _exitButton;
        public MainMenu(Application application) 
            : base("Main Menu", application)
        {
            _createJsonButton = new Button("Create Json");
            _loadJsonButton = new Button("Load Json");
            _exitButton = new Button("Exit");

            RegisterComponent(_createJsonButton);
            RegisterComponent(_loadJsonButton);
            RegisterComponent(_exitButton);

            _createJsonButton.Clicked += CreateJsonButtonClicked;
            _exitButton.Clicked += ExitButtonClicked;
               

        }

        private void CreateJsonButtonClicked()
        {
            Application app = _application;
            BackupJob backupJob = new BackupJob();
            BackupMethod backupMethod = new BackupMethod();
            BackupRetention backupRetention = new BackupRetention();

            IWindow window = new JsonSettingWindow(backupJob, backupMethod, backupRetention, _application,this);
            window.Show();
        }

        private void ExitButtonClicked()
        {
            _application.Stop();
        }






    }
}
