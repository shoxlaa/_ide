using _ide.Views;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ide.ViewModels
{
    public partial class StartViewModel : BaseViewModel
    {

        [ICommand]
        private void ClickMe()
        {
            WeakReferenceMessenger.Default.Send(new ValueChangedMessage<int>(1)); 

        } 

        
    }
}
