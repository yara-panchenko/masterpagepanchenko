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
    public partial class AchievementsPage : ContentPage
    {
        public AchievementsPage()
        {
            InitializeComponent();
        }

        private void modelZotac_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if (selectedIndex == 0)
            {
                choosen.Text = "Базовая частота ее GPU составит 1480 МГц, повышенная — 1582 МГц, а эффективная частота памяти GDDR5X — 11010 МГц.";
                imgchoosen.Source = ImageSource.FromFile("zotac1080.jpg");
            }
            else if (selectedIndex == 1)
            {
                choosen.Text = "Частота GPU (базовая): 1.350 МГц Частота памяти: 1.750 МГц Частота GPU(Boost): 1.635 МГц";
                imgchoosen.Source = ImageSource.FromFile("zotac2080.jpg");
            }
            else if (selectedIndex == 2)
            {
                choosen.Text = "Базовая частота, как и в случае NVIDIA, составляет 1.440 МГц, но ZOTAC увеличила частоту Boost до 1.770 МГц.";
                imgchoosen.Source = ImageSource.FromFile("zotac3080.jpg");
            }
            else if (selectedIndex == 3)
            {
                choosen.Text = "Карта оснащена 24 Гбайт видеопамяти GDDR6X с разрядностью шины 384 бит и эффективной частотой работы 19,5 ГГц.";
                imgchoosen.Source = ImageSource.FromFile("zotac3090.jpg");
            }
            else choosen.Text = "Фирма Zotac является одним из крупнейших производителей видеокарт";
        }
        private async void link_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.zotac.com/ru/page/graphics-cards-overview");
            await Browser.OpenAsync(uri);
        }
    }
}