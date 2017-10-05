using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageExercise
{
    public partial class MainPage : ContentPage
    {
        private int counter = 1;
        public MainPage()
        {
            InitializeComponent();
            counter = 1;
            LoadImage();
        }

        public void LoadImage()
        {
            myImage.Source = new UriImageSource()
            {
                Uri = new Uri($"http://lorempixel.com/1920/1080/city/{counter}"),
                CachingEnabled = false
            };
        }

        private void Button_OnClickedPrevious(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
                counter = 10;

            LoadImage();
        }

        private void Button_OnClickedNext(object sender, EventArgs e)
        {
            counter++;
            if (counter > 10)
                counter = 1;

            LoadImage();
        }
    }
}
