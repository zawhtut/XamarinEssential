using System;
using XamarinEssential.Model;
using Xamarin.Forms;

namespace XamarinEssential.View
{
    public partial class HomePage : BasePage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        async void OnSampleTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as SampleItem;
            if (item == null)
                return;

            await Navigation.PushAsync((Page)Activator.CreateInstance(item.PageType));

            // deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
