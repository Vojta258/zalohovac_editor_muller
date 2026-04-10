using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zalohovac_editor_muller.Presentation.Components;

namespace zalohovac_editor_muller.Presentation.Windows
{
    public class ChooseMoreBackupsWindow : BaseWindow
    {
        private Button _yesButton;
        private Button _noButton;
        public ChooseMoreBackupsWindow(Application application, IWindow? returnWindow) 
            : base("Do you want to add another Backup to this Json?", application, returnWindow)
        {
            _yesButton = new Button("yes");
            _noButton = new Button("no", true);

            RegisterComponent(_yesButton);
            RegisterComponent(_noButton);

            _yesButton.Clicked += YesButtonClicked;
            _noButton.Clicked += NoButtonClicked;

        }
       private void YesButtonClicked() //unožnilo by pokračovat v tvoření záloh do stejného souboru
        {

        }
       private void NoButtonClicked()
       {
            Close();
       }
    }
}
