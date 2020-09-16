using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



#if __IOS__
using UIKit;
using CoreGraphics;
#endif

namespace Hello14
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void OnColorChanged(object sender, EventArgs e)
        {
#if __IOS__
            var colorWell = (UIColorWell)sender; 
            nfloat r, g, b, a;
            colorWell.SelectedColor.GetRGBA(out r, out g, out b, out a);
            Xamagon.Fill = new SolidColorBrush(
                new Color((double)r, (double)g, (double)b, (double)a));
#endif
        }




    }
}
