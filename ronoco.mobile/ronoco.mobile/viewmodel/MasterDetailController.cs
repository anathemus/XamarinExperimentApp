using System;
using System.Collections.Generic;
using System.Text;
using ronoco.mobile.view;
using Xamarin.Forms;

namespace ronoco.mobile.viewmodel
{
    public class MasterDetailController : MasterDetailPage
    {
        MasterDetailMenu masterPage;

        public MasterDetailController()
        {
            masterPage = new MasterDetailMenu();
            NavigationPage initialDetailPage = new NavigationPage(new PolicyListView());
            initialDetailPage.BarBackgroundColor = Color.FromRgb(70, 120, 200);
            Master = masterPage;
            MasterBehavior = MasterBehavior.Popover;
            Detail = initialDetailPage;

            // masterPage.ListView.ItemSelected += OnItemSelected;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as model.MenuItem;

            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetPageType));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
