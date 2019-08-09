using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using HabiticaClone.Common.Visuals;
using HabiticaClone.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Entry), typeof(CustomEntryRenderer), new[] { typeof(CustomVisual) })]
namespace HabiticaClone.iOS.Renderers
{
    public class CustomEntryRenderer : MaterialEntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {

            }
        }
    }
}