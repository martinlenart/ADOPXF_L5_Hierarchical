using System;
using Xamarin.Forms;

namespace Hierarchical.Views
{
    public partial class Content1Page : ContentPage
    {
        public Content1Page()
        {
            InitializeComponent();
        }
		async void OnActionSheetSimpleClicked(object sender, EventArgs e)
		{
			var action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
            lblAnswer.Text = $"Action: {action}";
		}

		async void OnActionSheetCancelDeleteClicked(object sender, EventArgs e)
		{
			var action = await DisplayActionSheet("ActionSheet: SavePhoto?", "Cancel", "Delete", "Photo Roll", "Email");
            lblAnswer.Text = $"Action: {action}";
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new Content2Page());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}