using System;
using System.Collections.Generic;
using System.Text;

namespace TP1.Models
{
    public class Tweet
    {
        public string Mail { get; set; }
        public DateTime DateCreation { get; set; }
        public string Nom { get; set; }
        public string Pseudo { get; set; }
        public string Password { get; set; }
        public string Texte { get; set; }
    }

}
