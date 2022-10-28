using Authentication.ViewModels;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Store
{
    public class AuthenticationStore
    {
        private readonly FirebaseAuthProvider _firebaseAuthProvider;

        private FirebaseAuthLink _currentFirebaseLink;

        public AuthenticationStore(FirebaseAuthProvider firebaseAuthProvider)
        {
            _firebaseAuthProvider = firebaseAuthProvider;
        }

        public User? CurrentUser => _currentFirebaseLink?.User;

        public async Task Login(string email, string password)
        {
            _currentFirebaseLink = await _firebaseAuthProvider.SignInWithEmailAndPasswordAsync(email, password);
        }
    }
}
