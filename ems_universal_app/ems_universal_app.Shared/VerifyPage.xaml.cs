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
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ems_universal_app
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VerifyPage : Page
    {
        public VerifyPage()
        {
            this.InitializeComponent();
        }

        private void btnVerifyCode_Click(object sender, RoutedEventArgs e)
        {

           string  vcode = "123456" ;

            if(vcode == txtVcode.Text)
            {

                this.Frame.Navigate(typeof(HomePage));
            }else
            {

                lblDisplay.Text = "Verification code entered is invalid please enter Code sent to you via email";

            }


        }
    }
}
