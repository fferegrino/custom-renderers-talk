using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI.Xaml.Media;
using PokeDetail.Controls;
using PokeDetail.UWP.Controls;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(PkmnButton), typeof(PkmnButtonRenderer))]
namespace PokeDetail.UWP.Controls
{
    public class PkmnButtonRenderer : ButtonRenderer
    {
        static readonly FontFamily PokemonGBFontFamily = new FontFamily("/Assets/PokemonGB.ttf#Pokemon GB");

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
            Control.BackgroundColor = new SolidColorBrush(Windows.UI.Colors.Transparent);
            var t = new Windows.UI.Xaml.Thickness(5);
            Control.BorderThickness = t; // 5;
            Control.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Black);
        }

        private void SetFont()
        {
            Control.FontFamily = PokemonGBFontFamily;
        }
    }
}