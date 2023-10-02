using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace P1_Inversores
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
                private async void Button_Cliked(object sender, EventArgs e)
        {  
            double Inversor1 = 0;
            double Inversor2 = 0;
            double Inversor3 = 0;

            double total = 0;

            double resultado1 =0;
            double resultado2 =0;
            double resultado3 = 0;

            Inversor1 = Double.Parse(INVERSION1.Text);
            Inversor2 = Double.Parse(INVERSION2.Text);
            Inversor3 = Double.Parse(INVERSION3.Text);

            total=Inversor1 + Inversor2 + Inversor3;

            resultado1= (Inversor1 / total) * 100;
            resultado2 = (Inversor2 / total) * 100;
            resultado3 = (Inversor3 / total) * 100;

            await Navigation.PushAsync(new Page1(total.ToString(), resultado1.ToString("#.##"), resultado2.ToString("#.##"), resultado3.ToString("#.##")));
            }
        }
        
    }

