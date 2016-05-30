using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using PokeDetail.Controls;
using PokeDetail.iOS.Controls;
using UIKit;
using System.ComponentModel;

[assembly: ExportRenderer (typeof(PkmnLabel), typeof(PkmnLabelRenderer))]
namespace PokeDetail.iOS.Controls
{
    public class PkmnLabelRenderer : LabelRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (Control == null || Element == null)
                return;

            SetFont();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            SetFont();
        }

        private void SetFont()
        {
            var font = UIFont.FromName("PokemonGB", Control.Font.PointSize);
            Control.Font = font;
        }
    }
}

