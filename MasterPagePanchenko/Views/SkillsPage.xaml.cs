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
    public partial class SkillsPage : ContentPage
    {
        public SkillsPage()
        {
            InitializeComponent();
        }

        private void modelGigabyte_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if (selectedIndex == 0)
            {
                choosen.Text = "Тактовая частота ядра ГП Буст: 1657 МГц / Базовая: 1544 МГц в режиме OC Буст: 1632 МГц / Базовая: 1518 МГц в режиме Gaming";
                imgchoosen.Source = ImageSource.FromFile("gigabyte1080.jpg");
            }
            else if (selectedIndex == 1)
            {
                choosen.Text = "Тактовая частота GPU, МГц	1860 1950 2085";
                imgchoosen.Source = ImageSource.FromFile("gigabyte2080.jpg");
            }
            else if (selectedIndex == 2)
            {
                choosen.Text = "Частота GPU: 1440 МГц; Частота GPU Boost в играх: 1800 МГц; ";
                imgchoosen.Source = ImageSource.FromFile("gigabyte3080.png");
            }
            else if (selectedIndex == 3)
            {
                choosen.Text = "Частота работы GPU (ROPs), МГц	OC режим: 1395—1755(Boost)—2010(Max)	1395—1695(Boost)—1965(Max)";
                imgchoosen.Source = ImageSource.FromFile("gigabyte3090.png");
            }
            else choosen.Text = "Фирма Gigabyte является одним из крупнейших производителей видеокарт";
        }
        private async void link_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.gigabyte.com/ru/Graphics-Card");
            await Browser.OpenAsync(uri);
        }
    }
}