using System;
using System.Collections.Generic;
using TestUnosquere.ViewModel;
using Xamarin.Forms;

namespace TestUnosquere.View
{
    public partial class CarrosPage : ContentPage
    {
        CarrosViewModel context = new CarrosViewModel(new List<Carro> 
        {
            new Carro
            {
                Marca = "Chevrolet",
                Modelo = "Camaro",
                Anio = 1995
            },new Carro
            {
                Marca = "Ford",
                Modelo = "Mustang",
                Anio = 1964
            }
        });
        public CarrosPage()
        {
            InitializeComponent();
            BindingContext = context;
        }
    }
}
