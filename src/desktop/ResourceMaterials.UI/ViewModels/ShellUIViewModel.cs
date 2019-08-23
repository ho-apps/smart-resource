using Prism.Mvvm;

namespace ResourceMaterials.UI.ViewModels
{
    public class ShellUIViewModel : BindableBase
    {
        private string _title = "smart-resource Application";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public ShellUIViewModel()
        {

        }
    }
}
