using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoViews2
{
    public partial class Ejercicio3 : ContentPage
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }
        void CambiarColor(object sender, ValueChangedEventArgs e){
            var rojo = silROJO.Value;
            var azul = silAZUL.Value;
            var verde = silVERDE.Value;
            Color bgColor = new Color(rojo, verde, azul);
            boxColor.BackgroundColor = bgColor;
            lbDisplay.Text = ColorToHex(bgColor);


        }

        private string ColorToHex(Color color)
        {
            int rojo = (int)(color.R * 255);
            int verde = (int)(color.G * 255);
            int azul = (int)(color.B * 255);
            int alpha = (int)(color.A * 255);
            return $"#({rojo:x2}{verde:X2}{azul:X2}{alpha:X2})";
        }
    }

}
