using Hotel_Managment_Studio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hotel_Managment_Studio.State.Navigators
{
    public enum ViewType
    {
        Account,
        Search_room,
        Registration,
        History,
        Details
    }

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
