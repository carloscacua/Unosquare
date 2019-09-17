using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestUnosquere.ViewModel
{
    public class Carro : INotifyPropertyChanged
    {
        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private int anio;

        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }


        public string DisplayName
        {
            get { return $"Marca: {Marca} Modelo: {Modelo} Anio: {Anio}"; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "") 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name)); 
        }
    }
}
