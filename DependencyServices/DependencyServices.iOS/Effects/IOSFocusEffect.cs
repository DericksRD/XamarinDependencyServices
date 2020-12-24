using DependencyServices.iOS.Effects;
using Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("DericksRD")]
[assembly: ExportEffect(typeof(IOSFocusEffect), "FocusEffect")]
namespace DependencyServices.iOS.Effects
{
    class IOSFocusEffect : PlatformEffect
    {
        //Atributes:
        UIColor backgroundColor;

        //Methods:
        #region OnAttached
        protected override void OnAttached()
        {
            try
            {
                Control.BackgroundColor = backgroundColor = UIColor.FromRGB(204, 153, 255);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }
        #endregion

        #region OnDetached
        protected override void OnDetached()
        {

        }
        #endregion

        #region OnElementPropertyChanged
        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);


            try
            {
                if (args.PropertyName == "IsFocused")
                {
                    if (Control.BackgroundColor == backgroundColor)
                    {
                        Control.BackgroundColor = UIColor.White;
                    }
                    else
                    {
                        Control.BackgroundColor = backgroundColor;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);

            }
        }
        #endregion
    }
}