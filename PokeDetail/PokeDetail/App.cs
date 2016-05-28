using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PokeDetail
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new SearchPokemonCustomPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

// Font url: http://www.fontspace.com/jackster-productions/pokemon-gb