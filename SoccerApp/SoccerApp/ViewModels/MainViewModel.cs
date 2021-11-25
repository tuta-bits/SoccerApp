using SoccerApp.Models;
using SoccerApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SoccerApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<Team> _teamsList;

        private Team _selectedTeam = new Team();



        /// <summary>Gets or sets the teams list.</summary>
        /// <value>The teams list.</value>
        public List<Team> TeamsList 
        { 
            get {return _teamsList; }
            set 
            { 
                _teamsList = value;
                OnPropertyChanged();
            }
            
         }


        /// <summary>Gets or sets the selected team.</summary>
        /// <value>The selected team.</value>
        public Team SelectedTeam
        {
            get { return _selectedTeam; }
            set
            {
                _selectedTeam = value;
                OnPropertyChanged();
            }
        }



        /// <summary>
        /// Command for creating new team.
        /// </summary>
        public Command PostCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var teamsServices = new TeamServices();
                    await teamsServices.PostTeamsAsync(_selectedTeam);

                    await Application.Current.MainPage.DisplayAlert("Alert !", "New Team Created", "OK");

                });
            }
        }

        /// <summary>
        /// command for updating existing team info.
        /// </summary>
        public Command PutCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var teamsServices = new TeamServices();
                    await teamsServices.PutTeamsAsync(_selectedTeam.Id, _selectedTeam);

                    await Application.Current.MainPage.DisplayAlert("Alert !", "Team Info Has Been Updated", "OK");

                });
            }
        }

        /// <summary>
        /// command for deleting team
        /// </summary>
        public Command DeleteCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var teamsServices = new TeamServices();
                    await teamsServices.DeleteTeamsAsync(_selectedTeam.Id);

                    await Application.Current.MainPage.DisplayAlert("Alert !", "Team Has Been Deleted", "OK");

                });
            }
        }



        /// <summary>Gets the refresh command.</summary>
        /// <value>The refresh command.</value>
        public ICommand RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var teamsServices = new TeamServices();

                    TeamsList = await teamsServices.GetTeamsAsync();

                    IsRefreshing = false;

                });
            }
        }




        /// <summary>Initializes a new instance of the 
        /// <see cref="MainViewModel" /> class.</summary>
        public MainViewModel()
        {
            _ = InitializeDataAsync();
        }



        private async Task InitializeDataAsync()
        {
            var teamsServices = new TeamServices();

            TeamsList = await teamsServices.GetTeamsAsync();
        }




        /// <summary>Occurs when a property value changes.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>Called when [property changed].</summary>
        /// <param name="propertyName">Name of the property.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        /// <summary>The isrefreshing bool method</summary>
        private bool isRefreshing;


        /// <summary>Gets or sets a value indicating whether this instance is refreshing.</summary>
        /// <value>
        ///   <c>true</c> if this instance is refreshing; otherwise, <c>false</c>.</value>
        public bool IsRefreshing
        {
            get
            {
                return isRefreshing;
            }

            set
            {
                isRefreshing = value;
                OnPropertyChanged(nameof (IsRefreshing));
            }
        }

    }
}
