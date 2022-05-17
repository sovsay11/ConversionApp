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
     * - Controls: Buttons, labels, entries, frames, pickers
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
    /// Convert the length
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnConvertLength_Clicked(object sender, EventArgs e)
    {
      // Should go over data types...
      double length = double.Parse(EntLengthValue.Text);
      double convertedLength = length * 2.9;
      LblConvertedLength.Text = convertedLength.ToString();
    }

    /// <summary>
    /// Convert the temperature
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnConvertTemp_Clicked(object sender, EventArgs e)
    {
      // figure out how to round numbers...
      double temp = double.Parse(EntTempValue.Text);
      double convertedTemp = (temp - 32) * (5.0 / 9.0);
      LblConvertedTemp.Text = convertedTemp.ToString("n2");
    }
  }
}
