using zalohovac_editor_muller.Entities;
using zalohovac_editor_muller.Presentation.Components;

namespace zalohovac_editor_muller.Presentation.Windows
{
    public class JsonSettingWindow : BaseWindow
    {
        private BackupJob _backupJob;
        private BackupMethod _backupMethod;
        private BackupRetention _backupRetention; //service (prozatim bez toho)

        private TextBox _sourcesTextBox;
        private TextBox _targetsTextBox;
        private TextBox _methodTextBox; //pripadne checkboxama
        private TextBox _timingTextBox;

        private Label _retentionLabel; //will set it as default

        private TextBox _countTextBox;
        private TextBox _sizeTextBox;

        private Button _saveButton;
        private Button _cancelButton;

        public JsonSettingWindow(BackupJob backupJob,BackupMethod backupMethod, BackupRetention backupRetention ,Application application, IWindow? returnWindow = null) //jeste sem pak _backupJob
            : base("Json setting select", application, returnWindow)
        {
            _backupJob = backupJob;
            _backupMethod = backupMethod;
            _backupRetention = backupRetention;

            _sourcesTextBox = new TextBox("Sources :\t", 64);
            _targetsTextBox = new TextBox("Targets :\t", 64);
            _methodTextBox = new TextBox("Method :\t", 32);
            _timingTextBox = new TextBox("Timning :\t", 32);

            _retentionLabel = new Label("Retention");

            _countTextBox = new TextBox("Count :\t", 32);
            _sizeTextBox = new TextBox("Size :\t", 32);

            _saveButton = new Button("Save");
            _cancelButton = new Button("Cancle");

            RegisterComponent(_sourcesTextBox);
            RegisterComponent(_targetsTextBox);
            RegisterComponent(_methodTextBox);
            RegisterComponent(_timingTextBox);
            RegisterComponent(_retentionLabel);
            RegisterComponent(_countTextBox);
            RegisterComponent(_sizeTextBox);
            RegisterComponent(_saveButton);
            RegisterComponent(_cancelButton);

            _saveButton.Clicked += SaveButtonClicked;
            _cancelButton.Clicked += CancelButtonClicked;

        }

        //private void SetComponentValues()
        //{

        //}

        //private void SetEntityValues()
        //{
        //    _backupJob.Sources = _sourcesTextBox.Value;
        //    _backupJob.Targets = _targetsTextBox.Value;
        //    _backupJob.Method = _methodTextBox.Value;
        //    _backupJob.Timing = _timingTextBox.Value;
        //    _backupJob.
            

        //}

        private void SaveButtonClicked()
        {}

        private void CancelButtonClicked()
        {
            Close();
        }

    }
}
