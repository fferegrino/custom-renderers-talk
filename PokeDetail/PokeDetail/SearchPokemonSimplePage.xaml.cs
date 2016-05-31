using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jirapi;
using Jirapi.Resources;
using Xamarin.Forms;

namespace PokeDetail
{
    public partial class SearchPokemonSimplePage : ContentPage
    {
        public SearchPokemonSimplePage()
        {
            InitializeComponent();

            PokemonSearchBar.SearchButtonPressed += PokemonSearchPokemonButtonPressed;
            ClearInfoButton.Clicked += ClearInfoButton_Clicked;
        }

        private Pokemon pokemon;
        private PokemonSpecies pokemonSpecies;

        private async void PokemonSearchPokemonButtonPressed(object sender, EventArgs e)
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
                    PokemonShapeLabel.Text = "Shape: " + pokemonSpecies.Shape.Name;
                    ClearInfoButton.IsVisible = true;
                }
            }
            catch
            {
                // Jirapi throws an exception if it does not find the resource
                PokemonNameLabel.Text = "NOT FOUND";
                PokemonDescriptionLabel.Text = "";
                PokemonShapeLabel.Text = "";
                ClearInfoButton.IsVisible = false;
            }
            IsBusy = false;
        }

        private void ClearInfoButton_Clicked(object sender, EventArgs e)
        {
            PokemonNameLabel.Text = "";
            PokemonDescriptionLabel.Text = "";
            PokemonShapeLabel.Text = "";
            ClearInfoButton.IsVisible = false;
        }
    }
}
