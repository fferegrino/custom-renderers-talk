using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using PokeDetail.Controls;
using PokeDetail.iOS.Controls;
using UIKit;

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


            var font =  UIFont.FromName("Pokemon GB", Control.Font.PointSize);
            Control.Font = font;
        }
    }
}

