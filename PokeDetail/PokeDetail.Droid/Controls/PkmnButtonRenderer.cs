using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PokeDetail.Controls;
using PokeDetail.Droid.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(PkmnButton), typeof(PkmnButtonRenderer))]
namespace PokeDetail.Droid.Controls
{
    public class PkmnButtonRenderer : ButtonRenderer
    {
        static readonly Typeface PokemonGBFontFamily = Typeface.CreateFromAsset(Forms.Context.Assets, "PokemonGB.ttf");

        //protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        
        {
            base.OnElementChanged(e);
            if (Control == null || Element == null)
                return;

            
            SetFont();
            SetBorder();
        }

        private void SetBorder()
        {
            GradientDrawable gd = new GradientDrawable();
            gd.SetColor(Android.Graphics.Color.Transparent); // Changes this drawbale to use a single color instead of a gradient
            gd.SetCornerRadius(0);
            gd.SetStroke(5, Android.Graphics.Color.Black);
            Control.Background = gd;
        }

        private void SetFont()
        {
            Control.Typeface = PokemonGBFontFamily;
        }
    }
}