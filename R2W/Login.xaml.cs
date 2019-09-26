using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace R2W
{
    public partial class Login : ContentPage
    {
        Label label;

        public Login()
        {
            InitializeComponent();
            //Globals.API_ID.ToString();
            label = new Label { Text = "No Token Yet" };
            //this.Content = label;
            StackLayoutMap.Children.Add(label);
            Login_Submit.Clicked += OnClicked;
        }

        private void OnClicked(object sender, EventArgs e)
        {
            Entry email_entry = Login_Email;
            Entry password_entry = Login_Password;
            String temp = HTMLRequest.GETRequest(email_entry.Text, password_entry.Text);
            Button whichButton = (Button)sender;
            if (whichButton == Login_Submit)
                label.Text = "Your token is: \n" + temp;
        }
    }
}
