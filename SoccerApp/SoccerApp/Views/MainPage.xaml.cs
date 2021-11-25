using SoccerApp.Models;
using SoccerApp.ViewModels;
using SoccerApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SoccerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        /// <summary>Handles the Clicked event of the Button control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewTeamPage());
        }


        /// <summary>
        /// Event handler for item tapped. It will select the item and
        /// move its value to a new instance of MainViewModel named mainViewModel for
        /// data update or deleting.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Grande_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var MyTeam = Grande.SelectedItem as Team;

            if (MyTeam != null)
            {
                var mainViewModel = BindingContext as MainViewModel;

                if (mainViewModel != null)
                {
                    mainViewModel.SelectedTeam = MyTeam;

                    await Navigation.PushAsync(new NewTeamPage(mainViewModel));
                }
            }
        }
    }
}
