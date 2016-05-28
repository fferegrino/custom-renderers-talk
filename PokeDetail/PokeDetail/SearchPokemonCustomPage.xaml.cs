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
    public partial class SearchPokemonCustomPage : ContentPage
    {
        public SearchPokemonCustomPage()
        {
            InitializeComponent();

            searchBar.SearchButtonPressed += SearchPokemonButtonPressed;
            loadMoreInfoButton.Clicked += LoadMoreInfoButton_Clicked;
        }


        private Pokemon pokemon;
        private PokemonSpecies pokemonSpecies;

        private async void SearchPokemonButtonPressed(object sender, EventArgs e)
        {
            IsBusy = true;
            var pc = new PokeClient();

            try
            {
                pokemon = await pc.Get<Pokemon>(searchBar.Text.ToLower());
                if (pokemon != null)
                {
                    pokemonNameLabel.Text = pokemon.Name;
                    pokemonSpecies = await pokemon.Species.GetResource(pc);
                    pokemonDescriptionLabel.Text =
                        pokemonSpecies.FlavorTextEntries.First(desc => desc.Language.Name.Equals("en")).FlavorText;
                    pokemonHabitatLabel.Text = pokemonSpecies.Habitat.Name;
                    loadMoreInfoButton.IsVisible = true;
                }
            }
            catch
            {
                // Jirapi throws an exception if it does not find the resource
                pokemonNameLabel.Text = "NOT FOUND";
                pokemonDescriptionLabel.Text = "";
                pokemonHabitatLabel.Text = "";
                loadMoreInfoButton.IsVisible = false;
            }
            IsBusy = false;
        }

        private void LoadMoreInfoButton_Clicked(object sender, EventArgs e)
        {
            IsBusy = true;
            var pc = new PokeClient();

            IsBusy = false;
        }
    }
}
