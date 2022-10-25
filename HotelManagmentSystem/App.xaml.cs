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

namespace HotelManagmentSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost host;
        public App()
        {
            host = Host
                .CreateDefaultBuilder()
                .ConfigureServices((context, service) =>
              
                {
                    string firebaseApiKey = context.Configuration.GetValue<string>("FIREBASE_API_KEY");
                    service.AddSingleton(new FirebaseAuthProvider(new FirebaseConfig(firebaseApiKey)));

                    service.AddSingleton<MainWindow>((services) => new MainWindow());
                })
                .Build();
               
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = host.Services.GetRequiredService<MainWindow>();
            MainWindow.Show();

            FirebaseAuthProvider firebaseAuthProvider = host.Services.GetRequiredService<FirebaseAuthProvider>();
            firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync("test@gmail.com", "Test123!");
         
            base.OnStartup(e);
        }
    }
}
