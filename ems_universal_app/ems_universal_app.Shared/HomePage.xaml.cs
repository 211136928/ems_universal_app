using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Geolocation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ems_universal_app
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            objLoc = new getLocation();
            this.InitializeComponent();
        }

        private void btnUpdateDetails_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UpdateDetailsPage));
        }

        private void btnRequest_Click(object sender, RoutedEventArgs e)
        {
            string msg = "are you sure you are requesting for an ambulance to help you ?";

            //Send a request for help
            var messageDialog = new Windows.UI.Popups.MessageDialog(msg);

            // Add commands and set their callbacks; both buttons use the same callback function instead of inline event handlers
            messageDialog.Commands.Add(new UICommand(
                "Yes",
                new UICommandInvokedHandler(this.CommandInvokedHandler)));
            messageDialog.Commands.Add(new UICommand(
                "Cancel",
                new UICommandInvokedHandler(this.CommandInvokedHandler)));
            // Set the command that will be invoked by default
            messageDialog.DefaultCommandIndex = 0;
            // Set the command to be invoked when escape is pressed
            messageDialog.CancelCommandIndex = 1;
            // Show the message dialog
           // await messageDialog.ShowAsync();

          //  if (objLoc.getCurrentLocatino() != "")
           // {
            //    lblDisplay.Text = msg;

            //}
        }
private void CommandInvokedHandler(IUICommand command)
{
    if (command.Label == "Yes")
    {
        string loc;
        loc = objLoc.getCurrentLocatino();
        Frame.Navigate(typeof(commentPage));
    }
    throw new NotImplementedException();
} 
       internal  getLocation objLoc { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(commentPage));
        }
    }
}
