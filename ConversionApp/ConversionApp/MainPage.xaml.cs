using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConversionApp
{
    public partial class MainPage : ContentPage
    {
        // stuff to go over:
        /* Basics of XAML
         * - Layouts: grid, stack, scroll
         * - Controls: Buttons, labels, entries, frames
         * - Events: creating and triggering events
         */

        /// <summary>
        /// Main method that ties the UI and C# code together
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Convert lengths
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConvertLengths_Clicked(object sender, EventArgs e)
        {
            // if feet are entered
            if (EntInches.Text != null && EntInches.Text != "")
            {
                double inches = double.Parse(EntInches.Text);
                double centimeters = inches * 2.54;
                EntCentimeters.Text = centimeters.ToString("0.00");
            }
            // if centimeters are entered
            else if (EntCentimeters.Text != null && EntCentimeters.Text != "")
            {
                double centimeters = double.Parse(EntCentimeters.Text);
                double inches = centimeters / 2.54;
                EntInches.Text = inches.ToString("0.00");
            }
        }

        /// <summary>
        /// Convert temperatures
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConvertTemps_Clicked(object sender, EventArgs e)
        {
            // if fahrenheit is entered
            if (EntFahrenheit.Text != null && EntFahrenheit.Text != "")
            {
                double fahrenheit = double.Parse(EntFahrenheit.Text);
                double celsius = (fahrenheit - 32) * (5.0 / 9.0);
                EntCelsius.Text = celsius.ToString("0");
            }
            // if celsius is entered
            else if (EntCelsius.Text != null && EntCelsius.Text != "")
            {
                double celsius = double.Parse(EntCelsius.Text);
                double fahrenheit = (celsius * 9.0 / 5.0) + 32;
                EntFahrenheit.Text = fahrenheit.ToString("0");
            }
        }

        /// <summary>
        /// Clear lengths
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearLengths_Clicked(object sender, EventArgs e)
        {
            EntInches.Text = null;
            EntCentimeters.Text = null;
        }

        /// <summary>
        /// Clear temperatures
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearTemps_Clicked(object sender, EventArgs e)
        {
            EntFahrenheit.Text = null;
            EntCelsius.Text = null;
        }
    }
}
