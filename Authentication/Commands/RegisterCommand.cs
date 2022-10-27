using Authentication.ViewModels;
using Firebase.Auth;
using MVVMEssentials.Commands;
using MVVMEssentials.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Authentication.Commands
{
    public class RegisterCommand : AsyncCommandBase
    {
        private readonly RegisterViewModel _registerViewModel;
        private readonly FirebaseAuthProvider _firebaseAuthProvider;
        private readonly INavigationService _loginNavigationServicve;

        public RegisterCommand(RegisterViewModel registerViewModel, FirebaseAuthProvider firebaseAuthProvider, INavigationService loginNavigationServicve)
        {
            _registerViewModel = registerViewModel;
            _firebaseAuthProvider = firebaseAuthProvider;
            _loginNavigationServicve = loginNavigationServicve;
        }

        protected override async Task ExecuteAsync(object parameter)
        {
            string password = _registerViewModel.Password;
            string confirmPassword = _registerViewModel.ConfirmPassword;

            if (password != confirmPassword)
            {
                MessageBox.Show("Password and confirm password must match.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                return;
            }

            try
            {
                await _firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync(_registerViewModel.Email, password, _registerViewModel.Username);
                
                MessageBox.Show("Successfully registeres!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                //navigate to login page
                _loginNavigationServicve.Navigate();
            }
            catch (Exception)
            {
                MessageBox.Show("Registration failed. Please try again later.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                throw;
            }
        }
    }
}
