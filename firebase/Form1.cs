using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firebase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "FPY01jr4oxUdRx0d7vQfdeSglTHf9uhJ4gxjWkjb",
            BasePath = "https://hmsv1-9ca71-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("There was a problem connecting to the database ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Customers customers = new Customers() {
              Email =emailtext.Text,
              Username =usernametext.Text,
                Password=passwordtext.Text,
               
            };
            var setter = client.Set("CustomerList/" + usernametext.Text, customers);
            MessageBox.Show("data inserted successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = client.Get("CustomerList/" + usernametext.Text);
            Customers customers = result.ResultAs<Customers>();
            emailtext.Text = customers.Email;
            passwordtext.Text = customers.Password;
            MessageBox.Show("data retrieved successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers()
            {
                Email = emailtext.Text,
                Username = usernametext.Text,
                Password = passwordtext.Text,

            };
            var setter = client.Update("CustomerList/" + usernametext.Text, customers);
            MessageBox.Show("data updated successfully");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = client.Delete("CustomerList/" + usernametext.Text);
            MessageBox.Show("data updated successfully");
        }
    }
}
