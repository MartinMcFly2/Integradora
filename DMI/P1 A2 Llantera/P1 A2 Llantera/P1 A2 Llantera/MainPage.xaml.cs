using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace P1_A2_Llantera
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var llantas = double.Parse(LLANTAS.Text);
            double total = 0;
            string promocion = "";

            if (llantas >= 1 && llantas <= 4)
            {
                total = llantas * 350;
                promocion = "Se Aplica la Promo 1";

            }
            else if (llantas >= 5 && llantas <= 10)
            {
                total = llantas * 300;
                promocion = "Se Aplica la Promo 2";

            }
            else if (llantas > 10)
            {
                total = llantas * 250;
                promocion = "Se Aplica la Promo 3";
            }
            else
            {
                total = 0;
                promocion = "NO Aplica la Promo";
            }
            TOTAL.Text = total.ToString();
            DisplayAlert("Aviso", promocion, "OK");
        }
    }
}
