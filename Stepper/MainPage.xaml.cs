using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Stepper
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (DependencyService.Get<IStepCounter>().IsAvailable())
            {
                DependencyService.Get<IStepCounter>().InitSensorService();

                myBtn.IsVisible = true;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {


            mylabel.Text = DependencyService.Get<IStepCounter>().Steps.ToString();



        }
    }
}
