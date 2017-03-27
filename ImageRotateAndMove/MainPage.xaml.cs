using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ImageRotateAndMove
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private TranslateTransform dragTranslation;
        public MainPage()
        {
            this.InitializeComponent();
            MyGrid.ManipulationDelta += MyGrid_ManipulationDelta;
            // New translation transform populated in 
            // the ManipulationDelta handler.
            dragTranslation = new TranslateTransform();
            // Apply the translation to the Grid.
            MyGrid.RenderTransform= this.dragTranslation;
        }

        private void MyGrid_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            // Move the Image.
            dragTranslation.X += e.Delta.Translation.X;
            dragTranslation.Y += e.Delta.Translation.Y;
        }
    }
}
