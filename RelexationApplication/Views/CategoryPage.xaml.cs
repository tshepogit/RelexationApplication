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
	public partial class CategoryPage : ContentPage
	{
        Repository repository;
		public CategoryPage ()
		{
			InitializeComponent ();
            repository = new Repository();
            ShowCategories();
        }

        private void ShowCategories()
        {
            //Bind categories to the IU
            var categories = repository.GetCategories();
            categoryListView.ItemsSource = categories;
            categoryListView.ItemTemplate = new DataTemplate(typeof(TextCell));
            categoryListView.ItemTemplate.SetBinding(TextCell.TextColorProperty, "CategoryName");
        }

        private async void onClickItem(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Category;

            if (item == null)
                return;

            var stories = repository.GetCategoryDetails(item.CategoryId);

            switch (item.ClassId)
            {
                case 1:
                    await this.Navigation.PushModalAsync(new HeaderContentPage(stories, item.CategoryName));
                    break;
                case 2:
                    await this.Navigation.PushModalAsync(new LinesPage(stories, item.CategoryName));
                    break;
            }
        }
    }
}