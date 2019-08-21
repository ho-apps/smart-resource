using Prism.Mvvm;

namespace ResourceMaterials.Desktop.ViewModels
{
    public class ShellUIViewModel : BindableBase
    {
        private string _title = $"smart-resource app";

        public ShellUIViewModel()
        {
            
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
    }
}