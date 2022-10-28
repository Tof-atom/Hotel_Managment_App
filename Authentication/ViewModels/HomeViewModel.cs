using Authentication.Store;
using MVVMEssentials.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {

        private readonly AuthenticationStore _authenticationStore;

       public string Username => _authenticationStore.CurrentUser?.DisplayName ?? "Unknown";

        public HomeViewModel(AuthenticationStore authenticationStore)
        {
            _authenticationStore = authenticationStore;
        }
    }
}
