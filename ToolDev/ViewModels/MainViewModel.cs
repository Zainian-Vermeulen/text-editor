using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolDev.Models;

namespace ToolDev.ViewModels
{
    /// <summary>
    /// This class makes sure that the correct document is used through out the whole project
    /// </summary>
    
    public class MainViewModel
    {
        //document that is saved and loaded into the text editor
        private DocumentModel _document;
        
        //user input and document format / styles
        public EditorViewModel Editor { get; set; }
        
        //save and loading files
        public FileViewModel File { get; set; }
        
        //help dialog
        public HelpViewModel Help { get; set; }

        public MainViewModel()
        {
            _document = new DocumentModel();
            Help = new HelpViewModel();
            Editor = new EditorViewModel(_document);
            File = new FileViewModel(_document);
        }

    }
}
