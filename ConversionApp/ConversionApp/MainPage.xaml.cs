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
        // Basics of XAML
        // Basics of C# and tying stuff together
        // Go over page navigation later?
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnConvertLength_Clicked(object sender, EventArgs e)
        {
            double length = double.Parse(EntLengthValue.Text);
            double convertedLength = length * 2.9;
            LblConvertedLength.Text = convertedLength.ToString();
        }

        private void BtnConvertTemp_Clicked(object sender, EventArgs e)
        {
            // figure out how to round numbers...
            double temp = double.Parse(EntTempValue.Text);
            double convertedTemp = (temp - 32) * (5.0 / 9.0);
            LblConvertedTemp.Text = convertedTemp.ToString("n2");
        }
    }
}
