using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterPagePanchenko
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("fon.jpg");
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.AboutPage);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }
        private List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();

            list.Add(new MasterMenuItems()
            {
                Text = "Asus",
                Detail = "AsusTek Computer Inc. — расположенная на Тайване транснациональная компания, специализирующаяся на компьютерной электронике (как комплектующие, так и готовые продукты).",
                ImagePath = "asus.png",
                TargetPage = typeof(Views.AboutPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Nvidia",
                Detail = "Nvidia — американская технологическая компания, разработчик графических процессоров и систем-на-чипе.",
                ImagePath = "nvidia.png",
                TargetPage = typeof(Views.ExperiencePage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Gigabyte",
                Detail = "Тайваньская компания по производству системных плат, видеокарт и другой компьютерной техники.",
                ImagePath = "gigabyte.png",
                TargetPage = typeof(Views.SkillsPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Zotac",
                Detail = "Крупный поставщик компьютерных комплектующих, а именно видеокарт и материнских плат на базе процессоров NVIDIA",
                ImagePath = "zotac.jpg",
                TargetPage = typeof(Views.AchievementsPage)
            });
            return list;
        }


        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;

        }
    }
}
