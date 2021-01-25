using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterPagePanchenko.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExperiencePage : ContentPage
    {
        public ExperiencePage()
        {
            InitializeComponent();
        }

        private void modelNvidia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if (selectedIndex == 0)
            {
                choosen.Text = "Частота работы GPU (ROPs), МГц	1480—1885";
                imgchoosen.Source = ImageSource.FromFile("nvidia1080.png");
            }
            else if (selectedIndex == 1)
            {
                choosen.Text = "Частота работы ядра, МГц	1350–1545";
                imgchoosen.Source = ImageSource.FromFile("nvidia2080.jpg");
            }
            else if (selectedIndex == 2)
            {
                choosen.Text = "Частота работы ядра, МГц	1410–1740";
                imgchoosen.Source = ImageSource.FromFile("nvidia3080.jpg");
            }
            else if (selectedIndex == 3)
            {
                choosen.Text = "Частота работы ядра, МГц	1395–1695";
                imgchoosen.Source = ImageSource.FromFile("nvidia3090.png");
            }
            else choosen.Text = "Фирма Nvidia является одним из крупнейших производителей видеокарт";
        }
        private async void link_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.nvidia.com/ru-ru/geforce/buy/");
            await Browser.OpenAsync(uri);
        }
    }
}