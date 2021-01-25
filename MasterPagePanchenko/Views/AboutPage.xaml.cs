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
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void modelAsus_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if (selectedIndex == 0)
            {
                choosen.Text = "Графический процессор GeForce GTX 1080 Ti, 11 ГБ видеопамяти GDDR5X и оригинальная подсветка ASUS Aura";
                imgchoosen.Source =ImageSource.FromFile("asus1080.jpg");
                //Uri uri = new Uri("https://rog.asus.com/graphics-cards/graphics-cards/rog-strix/rog-strix-gtx1080ti-o11g-gaming-model/");
            }
            else if (selectedIndex == 1)
            {
                choosen.Text = "Геймерская видеокарта c 11 ГБ видеопамяти GDDR6 и современными технологиями для игр в разрешении 4K и виртуальной реальности";
                imgchoosen.Source = ImageSource.FromFile("asus2080.jpg");
            }
            else if (selectedIndex == 2)
            {
                choosen.Text = "GDDR6X видеокарта с 20 ГБ видеопамяти";
                imgchoosen.Source = ImageSource.FromFile("asus3080.jpg");

            }
            else if (selectedIndex == 3)
            {
                choosen.Text = "Карта имеет 24 ГБ памяти GDDR6X SDRAM, размещенной в 24 микросхемах по 8 Гбит на обеих сторонах PCB (по 12 на каждой).";
                imgchoosen.Source = ImageSource.FromFile("asus3090.jpg");
                //Uri uri = new Uri("https://www.asus.com/ru/Graphics-Cards/ROG-STRIX-RTX3090-24G-GAMING/");
            }
            else choosen.Text = "Фирма Asus является одним из крупнейших производителей видеокарт";
            //Uri uri = new Uri("https://www.asus.com/ru/Graphics-Cards/");
        }

        private async void link_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.asus.com/ru/Graphics-Cards/");
            await Browser.OpenAsync(uri);
        }
    }
}