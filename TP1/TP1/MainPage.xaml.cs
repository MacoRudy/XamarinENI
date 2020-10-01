using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Models;
using TP1.Services;
using TP1.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TP1
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ITwitterService twitterService;
        public MainPage()
        {
            this.twitterService = new TwitterService();
            InitializeComponent();
            this.connection.Clicked += Connection_Clicked;
            this.LoadTweets(this.StacklayoutTweets);

        }

        private void LoadTweets(StackLayout stacklayoutTweets)
        {
            foreach (var item in twitterService.GetTweets("truite"))
            {
                stacklayoutTweets.Children.Add(new TweetView().LoadData(item));
            }
        }

        private void Connection_Clicked(object sender, EventArgs e)
        {


            bool memo = this.memo.IsToggled;
            bool okId = false;
            bool okPwd = false;
            if (this.id.Text == null || this.id.Text.ToString().Trim().Length < 3)
            {
                this.error.Text = "L'identifiant doit avoir au moins 3 caractères";
                this.error.IsVisible = true;

            }
            else
            {
                okId = true;
            }

            if (this.password.Text == null || this.password.Text.ToString().Trim().Length < 6)
            {
                this.error.Text = "Le mot de passe doit avoir au moins 6 caractères";
                this.error.IsVisible = true;
            }
            else
            {
                okPwd = true;
            }
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                this.error.Text = "Veuillez vous connecter a internet";
                this.error.IsVisible = true;
            }
            if (twitterService.authenticate(this.id.Text.ToString(), this.password.Text.ToString()))
            {
                Debug.WriteLine(this.id.Text.ToString() + " " + this.password.Text.ToString() + " " + memo);
                this.scroll.IsVisible = true;
                this.login.IsVisible = false;
                this.error.IsVisible = false;
                
            }
            else
            {
                this.error.Text = "Mauvais combo user/password";
                this.error.IsVisible = true;
                this.id.Text = "";
                this.password.Text = "";
            }
        }
    }
}
