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
                case PokemonShape.Squiggle:
                    return UIPokemonShape.Squiggle;
                case PokemonShape.Fish:
                    return UIPokemonShape.Fish;
                case PokemonShape.Arms:
                    return UIPokemonShape.Arms;
                case PokemonShape.Blob:
                    return UIPokemonShape.Blob;
                case PokemonShape.Upright:
                    return UIPokemonShape.Upright;
                case PokemonShape.Legs:
                    return UIPokemonShape.Legs;
                case PokemonShape.Quadruped:
                    return UIPokemonShape.Quadruped;
                case PokemonShape.Wings:
                    return UIPokemonShape.Wings;
                case PokemonShape.Tentacles:
                    return UIPokemonShape.Tentacles;
                case PokemonShape.Heads:
                    return UIPokemonShape.Heads;
                case PokemonShape.Humanoid:
                    return UIPokemonShape.Humanoid;
                case PokemonShape.BugWings:
                    return UIPokemonShape.BugWings;
                case PokemonShape.Armor:
                    return UIPokemonShape.Armor;
                case PokemonShape.None:
                    return UIPokemonShape.None;
                default:
                    throw new ArgumentOutOfRangeException(nameof(shape), shape, null);
            }
        }
    }
}

