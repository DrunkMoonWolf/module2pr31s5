using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace module2pr31s5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void register(object sender, EventArgs e)
        {

        }
        public async void navig(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}
