using System.Windows;
using System.Windows.Controls;
using Ewars.Models;
using Ewars.ViewModels;
using SoftArcs.WPFSmartLibrary.SmartUserControls;

namespace Ewars.Views
{
	public partial class MainWindow
	{
		#region Fields

		public LoginViewModel ViewModel;

		#endregion

		#region Constructor

		public MainWindow()
		{
			InitializeComponent();

			this.ViewModel = new LoginViewModel();
			this.DataContext = this.ViewModel;
		}

		#endregion

		#region Event handler

		//+--------------------------------------------------------------------
		//+ Just for demo purposes - only to demonstrate code behind handling -
		//+--------------------------------------------------------------------
		private void btnLock_Click(object sender, RoutedEventArgs e)
		{
			this.SmartLoginOverlayControl.Lock();
		}

		private void btnChangeUser_Click(object sender, RoutedEventArgs e)
		{
			this.ViewModel.ChangeRecentUser( new User()
															{
																UserName = "Rand Shamaa",
																Password = "12345",
																EMailAddress = @"RandShamaa.com",
																ImageSourcePath = @"\Images\FemaleDoctor.png"
            } );

			this.SmartLoginOverlayControl.DisappearAnimation = DisappearAnimationType.MoveAndFadeOutToTopSimultaneous;
			this.SmartLoginOverlayControl.Lock();

			(sender as Button).IsEnabled = false;
		}

		// ReSharper disable UnusedMember.Local
		// ReSharper disable UnusedParameter.Local
		private void SmartLoginOverlay_SubmitRequested(object sender, RoutedEventArgs e)
		// ReSharper restore UnusedParameter.Local
		// ReSharper restore UnusedMember.Local
		{
			if (this.ViewModel.Password.Equals( this.ViewModel.UserPassword ))
			{
				this.SmartLoginOverlayControl.Unlock();
			}
			else
			{
				this.SmartLoginOverlayControl.ShowWrongCredentialsMessage();
			}
		}

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _ِAbout ab = new _ِAbout();
            ab.ShowDialog();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
