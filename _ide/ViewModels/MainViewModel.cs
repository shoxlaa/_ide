using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ide.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        [ObservableProperty]
        private BaseViewModel? _currentViewModel;
        private StartViewModel? _startViewModel;
        private EditorViewModel? _editorViewModel;

        public MainViewModel()
        {
            _startViewModel = new StartViewModel();
            _editorViewModel = new EditorViewModel();
            WeakReferenceMessenger.Default.Register<ValueChangedMessage<int>>(this, ChangeView);
            CurrentViewModel = _startViewModel;
        }

        private void ChangeView(object r, ValueChangedMessage<int> integer)
        {
            CurrentViewModel = integer.Value switch
            {
                0 => _startViewModel, 
                1 => _editorViewModel,
                _ => throw new Exception("Wrong ViewModel")
            };
        }

    }
}
