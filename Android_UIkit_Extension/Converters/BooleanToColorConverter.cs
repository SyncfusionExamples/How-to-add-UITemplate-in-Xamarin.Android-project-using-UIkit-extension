using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Android_UIkit_Extension.Converters
{
    /// <summary>
    /// This class have methods to convert the Boolean values to color objects. 
    /// This is needed to validate in the Entry controls. If the validation is failed, it will return the color code of error, otherwise it will be transparent.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class BooleanToColorConverter : IValueConverter
    {
        /// <summary>
        /// This method is used to convert the bool to color.
        /// </summary>
        /// <param name="value">Gets the value.</param>
        /// <param name="targetType">Gets the target type.</param>
        /// <param name="parameter">Gets the parameter.</param>
        /// <param name="culture">Gets the culture.</param>
        /// <returns>Returns the color.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
            {
                return Color.Default;
            }

            switch (parameter.ToString())
            {
                case "0" when (bool)value:
                    return Color.FromRgba(255, 255, 255, 0.6);
                case "1" when (bool)value:
                    return Color.FromHex("#FF4A4A");
                case "2" when (bool)value:
                    return Color.FromHex("#FF4A4A");
                case "2":
                    return Color.FromHex("#ced2d9");
                case "3" when (bool)value:
                    return Color.FromHex("#959eac");
                case "3":
                    return Color.FromHex("#959eac");
                case "4" when (bool)value:
                    return Color.FromHex("#f54e5e");
                case "4":
                    return Color.FromHex("#788396");
                case "5" when (bool)value:
                    return Color.FromHex("#7ed321");
                case "5":
                    return Color.FromHex("#ff4a4a");
                case "6" when (bool)value:
                    return Color.FromHex("#ced2d9");
                case "6":
                    return Color.FromHex("#d54381");
                case "7" when !(bool)value:
                    return Color.FromHex("#f6f7f8");
                case "8" when (bool)value:
                    return Color.FromHex("#f54e5e");
                case "8":
                    return Color.FromHex("#ffffff");
                default:
                    return Color.Transparent;
            }
        }

        /// <summary>
        /// This method is used to convert the color to bool.
        /// </summary>
        /// <param name="value">Gets the value.</param>
        /// <param name="targetType">Gets the target type.</param>
        /// <param name="parameter">Gets the parameter.</param>
        /// <param name="culture">Gets the culture.</param>
        /// <returns>Returns the string.</returns>        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}