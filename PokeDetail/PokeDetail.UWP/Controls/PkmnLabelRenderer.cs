using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using PokeDetail.Controls;
using PokeDetail.UWP.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly:ExportRenderer(typeof(PkmnLabel), typeof(PkmnLabelRenderer))]
namespace PokeDetail.UWP.Controls
{
    public class PkmnLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            base.OnElementChanged(e);
            if (Control == null || Element == null)
                return;

            SetFont();
        }

        private void SetFont()
        {
            FontFamily ff = new FontFamily("/Assets/PokemonGB.ttf#Pokemon GB");
            Control.FontFamily = ff;
        }
    }
}
