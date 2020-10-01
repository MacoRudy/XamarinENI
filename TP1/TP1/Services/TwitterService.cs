using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TP1.Models;

namespace TP1.Services
{
    class TwitterService : ITwitterService
    {
        public bool authenticate(string user, string password)
        {
            bool result = false;

            if (user == "rudy" && password == "maco")
            {
                result = true;
            }
            return result;
        }

        public ObservableCollection<Tweet> GetTweets(string truc)
        {
            ObservableCollection<Tweet> listeTweet = new ObservableCollection<Tweet>();

            listeTweet.Add(new Tweet
            {
                DateCreation = new DateTime(),
                Mail = "truite@poulpe.com",
                Nom = "Pedro",
                Pseudo = "Pedrolito",
                Password = "truite",
                Texte = "Faire en sorte que la méthode « authenticate » retourne vrai lorsqu’un couple " +
            "utilisateur / mot de passe de votre choix est saisi,faux sinon"
            });

            listeTweet.Add(new Tweet
            {
                DateCreation = new DateTime(),
                Mail = "rudy@maco.com",
                Nom = "Macorigh",
                Pseudo = "Alpina",
                Password = "rudy",
                Texte = "Donner un identifiant à chaque élément de formulaire : identifiant, mot de passe et" +
                "mémorisation et récupérer leur valeur au clic sur le bouton Connexion, dans le code behind."
            });

            listeTweet.Add(new Tweet
            {
                DateCreation = new DateTime(),
                Mail = "slacky@sleepy.com",
                Nom = "Slacky",
                Pseudo = "Sleepy",
                Password = "slacky",
                Texte = "Effectuer des contrôles de surface pour vérifier que l’identifiant est bien entré et fait" +
                " au moins 3 caractères et que le mot de passe est bien entré et fait au moins 6 caractères.Dans le cas contraire," +
                " afficher un message d’erreur à l’utilisateur pour luiindiquer le problème."
            });



            return listeTweet;
        }
    }
}
