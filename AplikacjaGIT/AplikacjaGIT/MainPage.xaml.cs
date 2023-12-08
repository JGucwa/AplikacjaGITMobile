using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AplikacjaGIT
{
    public partial class MainPage : ContentPage
    {
        static int Likes = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void IncreaseLikes(object s, EventArgs e)
        {
            Likes++;
            Liketext.Text = Likes.ToString();
        }
        private void DecreaseLikes(object s, EventArgs e)
        {
            if(Likes > 1) Likes--;

            Liketext.Text = Likes.ToString();
        }

    }
}
