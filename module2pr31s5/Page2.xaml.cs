using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace module2pr31s5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        public async void navig2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
        public void SignUp(object sender, EventArgs e)
        {
           
        }
    }
}