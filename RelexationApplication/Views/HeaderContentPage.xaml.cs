using RelexationApplication.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RelexationApplication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HeaderContentPage : ContentPage
	{
       private List<Story> _stories { get; set; }
        private string _categoryName { get; set; }

        public HeaderContentPage (List<Story> stories, string categoryName)
		{
			InitializeComponent ();
            this._stories = stories;
            this._categoryName = categoryName;
            ShowStories();
        }

        private void ShowStories()
        {
            storieslistView.ItemsSource = this._stories;
            storieslistView.ItemTemplate = new DataTemplate(typeof(TextCell));
            storieslistView.ItemTemplate.SetBinding(TextCell.TextColorProperty, "Title");
            lblcategoryName.Text = this._categoryName;
        }

        private async void onClickItem(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Story;
            if (item == null)
                return;
            await this.Navigation.PushModalAsync(new ReadingPage(item));
            storieslistView.SelectedItem = null;
        }
    }
}