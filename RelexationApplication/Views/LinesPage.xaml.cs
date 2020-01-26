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
	public partial class LinesPage : ContentPage
	{
        private List<Story> _stories { get; set; }
        private string _categoryName { get; set; }
        public LinesPage (List<Story> stories, string categoryName)
		{
			InitializeComponent ();
            this._stories = stories;
            this._categoryName = categoryName;

        }

        private void ShowStories()
        {
            storieslistView.ItemsSource = _stories;
            storieslistView.ItemTemplate = new DataTemplate(typeof(TextCell));
            storieslistView.ItemTemplate.SetBinding(TextCell.TextColorProperty, "Detail");
            lblcategoryName.Text = _categoryName;
        }
	}
}