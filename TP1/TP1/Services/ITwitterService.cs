using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TP1.Models;

namespace TP1.Services
{
    interface ITwitterService
    {
        bool authenticate(string user, string password);

        ObservableCollection<Tweet> GetTweets(string truc);
    }
}
