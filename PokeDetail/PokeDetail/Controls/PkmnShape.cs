using System;

using Xamarin.Forms;

namespace PokeDetail.Controls
{
    public class PkmnShape : View
    {
        public static readonly BindableProperty ShapeProperty =
            BindableProperty.Create(nameof(Shape), typeof(PokemonShape), typeof(PkmnShape), default(PokemonShape));

        public PkmnShape()
        {
            HorizontalOptions = LayoutOptions.Center;
        }

        public PokemonShape Shape
        {
            get { return (PokemonShape)GetValue(ShapeProperty); }
            set { SetValue(ShapeProperty, value); }
        }
    }

    public enum PokemonShape
    {
        None,
        Ball,
        Squiggle,
        Fish,
        Arms,
        Blob,
        Upright,
        Legs,
        Quadruped,
        Wings,
        Tentacles,
        Heads,
        Humanoid,
        BugWings,
        Armor
    }
}


