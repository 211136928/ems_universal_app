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
    public sealed partial class UpdateDetailsPage : Page
    {
        public UpdateDetailsPage()
        {
            this.InitializeComponent();

            


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomePage));
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            objValidate = new validation();

            string cellNumber, Email, address;
             string msg = "" ;
             string msg1;
            cellNumber = txtCellNum.Text;
            Email = txtEmail.Text;
            address = txtAddress.Text;

            if(objValidate.validateCellNum(cellNumber) != "" )
            {
                msg += objValidate.validateCellNum(cellNumber)+ "\n";
            }
            else if(objValidate.validateEmail(Email) != "")
            {
                msg += objValidate.validateEmail(Email) + "\n";
            }else if(address == "")
            {
                msg += "please provide your address \n";
            
            }
            else
            {
                msg1 = "Thanks you for updating your information ";
                //lblDisplay.Text = msg1;
                
                //this.Frame.Navigate(typeof(HomePage));
            }
    
            msg1 = "Thanks you for updating your information ";
            if (msg != "")
                lblDisplay.Text = msg;
            else
                lblDisplay.Text = msg1;
        }

        internal validation objValidate { get; set; }
    }
}
