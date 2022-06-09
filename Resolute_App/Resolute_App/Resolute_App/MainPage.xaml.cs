using Resolute_App.MessagingUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Resolute_App
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            var pages = Children.GetEnumerator();
            //moves the pages to go and set the home page as the default page
            pages.MoveNext(); //first page
            pages.MoveNext(); //second page
            CurrentPage = pages.Current;
        }
    }
}
