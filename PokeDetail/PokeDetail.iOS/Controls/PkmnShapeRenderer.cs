using System;
using PokeDetail.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using PokeDetail.iOS.Controls;
using CoreGraphics;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(PkmnShape), typeof(PkmnShapeRenderer))]
namespace PokeDetail.iOS.Controls
{
    public class PkmnShapeRenderer : ViewRenderer<PkmnShape, UIPkmnShape>
    {
        public PkmnShapeRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<PkmnShape> e)
        {
            base.OnElementChanged(e);


            if (Control == null)
            {
                // Instantiate the native control and assign it to the Control property
                var shape = new UIPkmnShape(new CGRect(0, 0, Element.WidthRequest, Element.HeightRequest))
                {
                    Shape = ToUIPokemonShape(Element.Shape)
                };
                SetNativeControl(shape);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("Shape"))
            {
                Control.Shape = ToUIPokemonShape(Element.Shape);
            }
            else
            {
                base.OnElementPropertyChanged(sender, e);
            }
        }

        private UIPokemonShape ToUIPokemonShape(PokemonShape shape)
        {
            switch (shape)
            {
                case PokemonShape.Ball:
                    return UIPokemonShape.Ball;
                    break;
                case PokemonShape.Squiggle:
                    return UIPokemonShape.Squiggle;
                    break;
                case PokemonShape.Fish:
                    return UIPokemonShape.Fish;
                    break;
                case PokemonShape.Arms:
                    return UIPokemonShape.Arms;
                    break;
                case PokemonShape.Blob:
                    return UIPokemonShape.Blob;
                    break;
                case PokemonShape.Upright:
                    return UIPokemonShape.Upright;
                    break;
                case PokemonShape.Legs:
                    return UIPokemonShape.Legs;
                    break;
                case PokemonShape.Quadruped:
                    return UIPokemonShape.Quadruped;
                    break;
                case PokemonShape.Wings:
                    return UIPokemonShape.Wings;
                    break;
                case PokemonShape.Tentacles:
                    return UIPokemonShape.Tentacles;
                    break;
                case PokemonShape.Heads:
                    return UIPokemonShape.Heads;
                    break;
                case PokemonShape.Humanoid:
                    return UIPokemonShape.Humanoid;
                    break;
                case PokemonShape.BugWings:
                    return UIPokemonShape.BugWings;
                    break;
                case PokemonShape.Armor:
                    return UIPokemonShape.Armor;
                    break;
                case PokemonShape.None:
                    return UIPokemonShape.None;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(shape), shape, null);
            }
        }
    }
}

