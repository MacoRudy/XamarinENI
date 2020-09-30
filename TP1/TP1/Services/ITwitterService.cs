using System;
using System.Collections.Generic;
using System.Text;
using TP1.Models;

namespace TP1.Services
{
    interface ITwitterService
    {
        bool authenticate(string user, string password);

        List<Tweet> GetTweets(string truc);
    }
}
