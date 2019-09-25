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
            label = new Label { Text = "asdfadfasd" };
            //this.Content = label;
            StackLayoutMap.Children.Add(label);
            Login_Submit.Clicked += OnClicked;
        }

        private void OnClicked(object sender, EventArgs e)
        {
            Button whichButton = (Button)sender;
            if (whichButton == Login_Submit)
                label.Text = "Tried to login";
        }
    }
}
