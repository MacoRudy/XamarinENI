using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Models;
using TP1.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetPage : ContentPage
    {
        public TweetPage()
        {
            InitializeComponent();
            ObservableCollection<Tweet> Tweets = new ObservableCollection<Tweet>();
            ITwitterService twitterService = new TwitterService();
            Tweets = twitterService.GetTweets("truite");
            this.TweetList.ItemsSource = Tweets;
        }
    }
}