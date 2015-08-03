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
    public sealed partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            this.InitializeComponent();
            lstProvince.Items.Add("Limpopo");
            lstProvince.Items.Add("Guateng");
            lstProvince.Items.Add("Mpumalanga");
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            vali = new validation();

            string name,surname,ID, Email,cellNumber,  password, vpassword;
             string  msg = "";

            ID = txtID.Text;
            name = txtname.Text;
            surname = txtSurname.Text;
            cellNumber = txtCellNumber.Text;
            Email = txtEmail.Text;
            password = txtPassword.ToString();
            vpassword = txtVpasswrd.ToString();

            //msg =vali.validateString(name);

            if (vali.IDValidation(ID) != "")
            {
                msg += vali.IDValidation(ID) + "\n";
                //txtID.Focus();
            }
            if(vali.validateString(name) != "")
            {
                msg += vali.validateString(name) + "\n";
                
            }
            if(vali.validateCellNum(cellNumber) != "")
            {
                msg += "cellNumber" + vali.validateCellNum(cellNumber) + "\n";
            }




            if (chkTerm.IsChecked == false)
            {
                msg += "chect the terms and condition" + "\n";

            }
            if(msg == "" ) 
            {
                string msgR = "Thanks you for registering with our EMS service";
                messageR(msgR);
            }
            else
            {
                messageBox(msg);
            }


        }

        internal validation vali { get; set; }

        private void btnVerify_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }


        private async void messageBox(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            msgDlg.DefaultCommandIndex = 1;
            await msgDlg.ShowAsync();
        }

        private async void messageR(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            msgDlg.DefaultCommandIndex = 1;
            await msgDlg.ShowAsync();
            this.Frame.Navigate(typeof(HomePage));
        }


    }
}
