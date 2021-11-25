using SoccerApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoccerApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTeamPage : ContentPage
    {


        /// <summary>Initializes a new instance of the <see cref="NewTeamPage" /> class.</summary>
        public NewTeamPage()
        {
            InitializeComponent();
        }



        /// <summary>Initializes a new instance of the <see cref="NewTeamPage" /> class.</summary>
        /// <param name="mainViewModel">The main view model.</param>
        public NewTeamPage(MainViewModel mainViewModel)
        {
            InitializeComponent();

            BindingContext = mainViewModel;
        }
    }
}