using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetView : ContentView
    {
        Random rand = new Random();
        public TweetView()
        {
            InitializeComponent();
        }

        public TweetView LoadData(Tweet item)
        {
            
            this.pseudo.Text = item.Pseudo;
            this.texte.Text = item.Texte;
            this.mail.Text = item.Mail;
            this.dateCreation.Text = item.DateCreation.ToString();
            this.BackgroundColor = Color.FromRgb(rand.Next(256), rand.Next(256), rand.Next(256));

            return this;
        }
    }
}