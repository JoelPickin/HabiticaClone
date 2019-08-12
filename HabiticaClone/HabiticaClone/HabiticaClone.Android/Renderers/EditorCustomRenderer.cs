using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HabiticaClone.Common.Visuals;
using HabiticaClone.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Editor), typeof(EditorCustomRenderer), new[] { typeof(CustomVisual) })]
namespace HabiticaClone.Droid.Renderers
{
    public class EditorCustomRenderer : MaterialEditorRenderer
    {
        public EditorCustomRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {

            }
            if (e.NewElement != null)
            {

            }
        }
    }
}