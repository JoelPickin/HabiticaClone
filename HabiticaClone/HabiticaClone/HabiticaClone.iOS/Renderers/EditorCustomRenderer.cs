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

[assembly: ExportRenderer(typeof(Xamarin.Forms.Editor), typeof(EditorCustomRenderer), new[] { typeof(CustomVisual) })]
namespace HabiticaClone.iOS.Renderers
{
    public class EditorCustomRenderer : MaterialEditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {

            }
        }
    }
}