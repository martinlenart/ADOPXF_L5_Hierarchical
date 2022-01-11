using System;
using Xamarin.Forms;

namespace Hierarchical.Views
{
    public partial class Content2Page : ContentPage
    {
        public Content2Page()
        {
            InitializeComponent();
        }
        async void OnAlertSimpleClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "You have been alerted", "OK");
        }

        async void OnAlertYesNoClicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            lblAnswer.Text = $"Action: {answer}";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Content3Page());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}