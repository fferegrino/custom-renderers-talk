using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using PokeDetail.Controls;
using PokeDetail.iOS.Controls;
using UIKit;
using System.ComponentModel;

[assembly: ExportRenderer (typeof(PkmnButton), typeof(PkmnButtonRenderer))]
namespace PokeDetail.iOS.Controls
{
    public class PkmnButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control == null || Element == null)
                return;

            SetFont(); SetBorder();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            SetFont();
            SetBorder();
        }

        private void SetBorder()
        {
            Control.Layer.BorderWidth = 5;
            Control.Layer.BorderColor = UIColor.Black.CGColor;
        }
        private void SetFont()
        {
            var font = UIFont.FromName("PokemonGB", Control.Font.PointSize);
            Control.Font = font;
            Control.SetTitleColor(UIColor.Black, UIControlState.Normal);
        }
    }
}

