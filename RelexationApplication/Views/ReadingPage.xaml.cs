using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RelexationApplication.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReadingPage : ContentPage
	{
		public ReadingPage (Story story)
		{
			InitializeComponent ();
            Read(story);
        }

        private void Read(Story story)
        {
            title.Text = story.Title;
            details.Text = story.Detail;
        }
	}
}