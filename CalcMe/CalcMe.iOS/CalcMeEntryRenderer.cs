using CalcMe.Controls;
using CalcMe.iOS;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CalcMeEntry), typeof(CalcMeEntryRenderer))]
namespace CalcMe.iOS
{
    public class CalcMeEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            this.Control.InputView = new UIView();
        }
    }
}