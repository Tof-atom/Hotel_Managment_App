using Firebase.Auth;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Authentication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly IHost _host;


        public App()
        {
            _host = Host
                .CreateDefaultBuilder()
                .ConfigureServices((context, service) =>
                {
                    //  string firebaseApiKey = context.Configuration.GetValue<string>("FIREBASE_API_KEY");
                    string firebaseApiKey = "AIzaSyCLDk10jdvvaCD7oGl7Z0BrIgaoIKJ0exI";
                    service.AddSingleton(new FirebaseAuthProvider(new FirebaseConfig(firebaseApiKey)));

                    service.AddSingleton<MainWindow>((services) => new MainWindow());
                })
                .Build();

        }

        protected override void OnStartup(StartupEventArgs e)
        {   
            MainWindow = _host.Services.GetRequiredService<MainWindow>();
            MainWindow.Show();

            FirebaseAuthProvider firebaseAuthProvider = _host.Services.GetRequiredService<FirebaseAuthProvider>();
            firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync("customer@mts.ca", "Test123!");

            

            base.OnStartup(e);
        }
    }
}
