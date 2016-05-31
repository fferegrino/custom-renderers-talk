using System;
using PokeDetail.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using PokeDetail.iOS.Controls;
using CoreGraphics;

[assembly: ExportRenderer(typeof(PkmnShape), typeof(PkmnShapeRenderer))]
namespace PokeDetail.iOS.Controls
{
	public class PkmnShapeRenderer : ViewRenderer<PkmnShape, UIPkmnShape>
	{
		public PkmnShapeRenderer ()
		{
		}

		protected override void OnElementChanged (ElementChangedEventArgs<PkmnShape> e)
		{
			base.OnElementChanged (e);


			if (Control == null)
			{
				// Instantiate the native control and assign it to the Control property
				var shape = new UIPkmnShape(new CGRect(0, 0, Element.WidthRequest, Element.HeightRequest))
				{
                        Shape = PokemonShape.Armor
				};

				SetNativeControl(shape);
			}
		}
	}
}

