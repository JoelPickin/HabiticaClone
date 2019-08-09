using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HabiticaClone.Common.Visuals;
using HabiticaClone.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Entry), typeof(CustomEntryRenderer), new[] { typeof(CustomVisual) })]
namespace HabiticaClone.Droid.Renderers
{
    public class CustomEntryRenderer : MaterialEntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
            
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {

            }
        }
    }
}