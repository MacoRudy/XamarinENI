using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP1
{
 
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.connection.Clicked += Connection_Clicked;
        }

        private void Connection_Clicked(object sender, EventArgs e)
        {
            string password = this.password.Text.ToString();
            string id = this.id.Text.ToString();
            string memo = this.memo.IsToggled.ToString();
            Debug.WriteLine(id + " " + password + " " + memo);
            bool okId = false;
            bool okPwd = false;
            if (id.Trim().Length < 3 )
            {
                this.error.Text = "L'identifiant doit avoir au moins 3 caractères";
                this.error.IsVisible = true;

            } else
            {
                okId = true;
            }

            if (password.Trim().Length < 6)
            {
                this.error.Text = "Le mot de passe doit avoir au moins 6 caractères";
                this.error.IsVisible = true;
            } else
            {
                okPwd = true;
            }

            if (okId && okPwd)
            {
                this.scroll.IsVisible = true;
                this.login.IsVisible = false;
                this.error.IsVisible = false;
            }
        }
    }
}
