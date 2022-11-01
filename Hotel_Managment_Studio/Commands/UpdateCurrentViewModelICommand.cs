using Hotel_Managment_Studio.State.Navigators;
using Hotel_Managment_Studio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hotel_Managment_Studio.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Account:
                        _navigator.CurrentViewModel = new AccountViewModel();
                        break;
                    case ViewType.Search_room:
                        _navigator.CurrentViewModel = new SearchRoomViewModel();
                        break;
                    case ViewType.Registration:
                        _navigator.CurrentViewModel = new RegistrationViewModel();
                        break;
                    case ViewType.History:
                        _navigator.CurrentViewModel = new HistoryViewModel();
                        break;
                    case ViewType.Details:
                        
                        break;
                    default:
                        break;
                }
            }
        }
    }
}