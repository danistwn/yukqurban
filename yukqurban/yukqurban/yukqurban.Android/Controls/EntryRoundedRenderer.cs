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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using yukqurban.Controls;
using yukqurban.Droid.Controls;

[assembly : ExportRenderer(typeof(EntryRounded),typeof(EntryRoundedRenderer))]
namespace yukqurban.Droid.Controls
{
    public class EntryRoundedRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var view = (EntryRounded)Element;               
                    // creating gradient drawable for the curved background  
                    var _gradientBackground = new GradientDrawable();
                    _gradientBackground.SetShape(ShapeType.Rectangle);
                    _gradientBackground.SetColor(view.BackgroundColor.ToAndroid());

                    // Thickness of the stroke line  
                    _gradientBackground.SetStroke(1, Color.Gray.ToAndroid());

                _gradientBackground.SetCornerRadius(5);

                // set the background of the   
                Control.SetBackground(_gradientBackground);                

            }
        }
    }
}