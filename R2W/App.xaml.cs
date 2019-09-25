using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace R2W
{
    public static class Globals
    {
        public static string API_LINK = "https://R2wmobile4.running2win.com/api.asmx";
        public static string API_ID = "72329725-b904-4ecf-a4dc-ecdad2ed1f03";
        public static string API_VENDOR = "dd840f73-f071-475e-b0c5-5dd357a907f8";
    }
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login();

            //string token = "";
        }

        protected override void OnStart()
        {

            //string urlParameters = "";
            //// Handle when your app starts
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(Globals.API_LINK);
            //client.DefaultRequestHeaders.Accept.Add(
            //new MediaTypeWithQualityHeaderValue("application/json"));

            //HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            //if (response.IsSuccessStatusCode)
            //{
            //    // Parse the response body.
            //    var dataObjects = response.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
            //    foreach (var d in dataObjects)
            //    {
            //        Console.WriteLine("{0}", d.Name);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            //}

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void Top20()
        {

        }

        private void LogIn(string username, string password)
        {

        }
    }
}
