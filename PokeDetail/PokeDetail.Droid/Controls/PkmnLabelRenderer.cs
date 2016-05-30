using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PokeDetail.Controls;
using PokeDetail.Droid.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(PkmnLabel), typeof(PkmnLabelRenderer))]
namespace PokeDetail.Droid.Controls
{
    public class PkmnLabelRenderer : LabelRenderer
    {
        static readonly Typeface PokemonGBFontFamily = Typeface.CreateFromAsset(Forms.Context.Assets, "PokemonGB.ttf");

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control == null || Element == null)
                return;

            SetFont();
        }

        private void SetFont()
        {
            Control.Typeface = PokemonGBFontFamily;
        }
    }
}