using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.Graphics.Canvas.UI.Xaml;
using PokeDetail.Controls;
using PokeDetail.UWP.Controls;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(PkmnShape), typeof(PkmnShapeRenderer))]
namespace PokeDetail.UWP.Controls
{
    public class PkmnShapeRenderer : ViewRenderer<PkmnShape, TextBlock>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<PkmnShape> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                // Instantiate the native control and assign it to the Control property
                var shape = new TextBlock()
                {
                    Width = Element.WidthRequest,
                    Height = Element.HeightRequest,
                    FontSize = Element.HeightRequest - (Element.HeightRequest * .15),
                    TextAlignment = TextAlignment.Center,
                    Text = ToEmojiPokemonShape(Element.Shape)
                };
                SetNativeControl(shape);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("Shape"))
            {
                Control.Text = ToEmojiPokemonShape(Element.Shape);
            }
            else
            {
                base.OnElementPropertyChanged(sender, e);
            }
        }


        private string ToEmojiPokemonShape(PokemonShape shape)
        {
            switch (shape)
            {
                case PokemonShape.Ball:
                    return "⚫";
                case PokemonShape.Squiggle:
                    return "🐍";
                case PokemonShape.Fish:
                    return "🐟";
                case PokemonShape.Arms:
                    return "👐";
                case PokemonShape.Blob:
                    return "🌀";
                case PokemonShape.Upright:
                    return "🚶";
                case PokemonShape.Legs:
                    return "👟";
                case PokemonShape.Quadruped:
                    return "🐎";
                case PokemonShape.Wings:
                    return "🐦";
                case PokemonShape.Tentacles:
                    return "🐙";
                case PokemonShape.Heads:
                    return "👥";
                case PokemonShape.Humanoid:
                    return "💃";
                case PokemonShape.BugWings:
                    return "🐝";
                case PokemonShape.Armor:
                    return "🐜";
                case PokemonShape.None:
                    return "🚫";
                default:
                    throw new ArgumentOutOfRangeException(nameof(shape), shape, null);
            }
        }
    }
}
