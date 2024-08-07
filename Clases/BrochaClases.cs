using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3716370Practica13.Clases
{
    public partial class BrochaClases: ObservableObject
    {

        [ObservableProperty]
        private double precio;

        [ObservableProperty]
        private double areapintar;

        [ObservableProperty]
        private double costo;

        [ObservableProperty]
        private int cliente;

        [ObservableProperty]
        private double clientep;


        [RelayCommand]
        public void Total()
        {
            Costo = Precio * Areapintar;
       
          Clientep= Costo/Cliente;
        }
    }
}
