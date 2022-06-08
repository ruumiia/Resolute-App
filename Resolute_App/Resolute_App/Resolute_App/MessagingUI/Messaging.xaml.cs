using Resolute_App.MessagingUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Resolute_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Messaging : ContentPage
    {
        public Messaging()
        {
            InitializeComponent();
        }

        private void ChatUser1_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Chatbox());
        }
    }
}