using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace TestUnosquere.ViewModel
{
    public class CarrosViewModel : Carro
    {
        public ObservableCollection<Carro> Carros;
        Carro modelo;

        public Command GuardarCommando { get; set; } 

        public CarrosViewModel(List<Carro> list) 
        {
            Carros = new ObservableCollection<Carro>();

            foreach (var item in list)
                Carros.Add(item);

            GuardarCommando = new Command(() => Guardar(), () => !invalidSave());
        }

        private void Guardar() 
        {

            modelo = new Carro
            {
                Marca = Marca,
                Modelo = Modelo,
                Anio = Anio
            };

            Carros.Add(modelo);
        }

        private bool invalidSave() 
        {
            return Carros.Any(c => c.Modelo == Modelo && c.Marca == Marca && c.Anio == Anio);
        }
    }
}
