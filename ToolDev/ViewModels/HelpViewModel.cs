using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToolDev.ViewModels
{
    /// <summary>
    /// This class opens the help / about dialog
    /// </summary>
    public class HelpViewModel : ObserveObject
    {
        public ICommand HelpCommand { get; }

        public HelpViewModel()
        {
            HelpCommand = new RelayCommand(DisplayAbout);
        }

        private void DisplayAbout()
        {
            var helpDialog = new HelpDialog();
            helpDialog.ShowDialog();
        }
    }
}
