using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jirapi;
using Jirapi.Resources;
using Xamarin.Forms;
using PokemonShape = PokeDetail.Controls.PokemonShape;

namespace PokeDetail
{
    public partial class SearchPokemonCustomPage : ContentPage
    {
        private Random r = new Random();
        public SearchPokemonCustomPage()
        {
            InitializeComponent();

            PokemonSearchBar.SearchButtonPressed += SearchPokemonButtonPressed;
            ClearInfoButton.Clicked += ClearInfoButton_Clicked; ;
        }

        private Pokemon pokemon;
        private PokemonSpecies pokemonSpecies;

        private async void SearchPokemonButtonPressed(object sender, EventArgs e)
        {
            IsBusy = true;
            var pc = new PokeClient();

            try
            {
                pokemon = await pc.Get<Pokemon>(PokemonSearchBar.Text.ToLower());
                if (pokemon != null)
                {
                    PokemonNameLabel.Text = pokemon.Name;
                    pokemonSpecies = await pokemon.Species.GetResource(pc);
                    PokemonDescriptionLabel.Text =
                        pokemonSpecies.FlavorTextEntries.First(desc => desc.Language.Name.Equals("en")).FlavorText;
                    PkmnShape.Shape = StringToShape(pokemonSpecies.Shape.Name);
                    ClearInfoButton.IsVisible = true;
                }
            }
            catch(Exception ett)
            {
                // Jirapi throws an exception if it does not find the resource
                PokemonNameLabel.Text = "NOT FOUND";
                PokemonDescriptionLabel.Text = "";
                PkmnShape.Shape = PokemonShape.None;
                ClearInfoButton.IsVisible = false;
            }
            IsBusy = false;
        }

        private void ClearInfoButton_Clicked(object sender, EventArgs e)
        {
            PokemonNameLabel.Text = "";
            PokemonDescriptionLabel.Text = "";
            PkmnShape.Shape = PokemonShape.None;
            ClearInfoButton.IsVisible = false;
        }

        private PokemonShape StringToShape(string name)
        {

            switch (name)
            {
                case "ball":
                    return PokemonShape.Ball;
                case "squiggle":
                    return PokemonShape.Squiggle;
                case "fish":
                    return PokemonShape.Fish;
                case "arms":
                    return PokemonShape.Arms;
                case "blob":
                    return PokemonShape.Blob;
                case "upright":
                    return PokemonShape.Upright;
                case "legs":
                    return PokemonShape.Legs;
                case "quadruped":
                    return PokemonShape.Quadruped;
                case "wings":
                    return PokemonShape.Wings;
                case "tentacles":
                    return PokemonShape.Tentacles;
                case "heads":
                    return PokemonShape.Heads;
                case "humanoid":
                    return PokemonShape.Humanoid;
                case "bug-wings":
                    return PokemonShape.BugWings;
                default:
                    return PokemonShape.None;
            }
        }
    }
}
