using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3716370Practica13.Clases
{
    public partial class DistanciaClases : ObservableObject
    {

        [ObservableProperty]
        public double x1;

        [ObservableProperty]
        public double x2;

        [ObservableProperty]
        public double y1;

        [ObservableProperty]
        public double y2;

        [ObservableProperty]
        public double rel;


        [RelayCommand]
        public void Distancia()
        {
             Rel = Math.Round((Math.Pow(X1 - Y1, 2) + Math.Pow(X2 - Y2, 2)), 2);
        }
    }
}
