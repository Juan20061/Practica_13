using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3716370Practica13.Clases
{
    public partial class TrianguloClases:ObservableObject
    {
        [ObservableProperty]
        private double b;

        [ObservableProperty]
        private double a;

        [ObservableProperty]
        private double c;

        [ObservableProperty]
        private double area;

        [RelayCommand]
        public void triangulo()
        {
            Area = (A + B + C) / 2;
            Area = Math.Sqrt(Area * (Area - A) * (Area - A) * (Area - A));
        }
    }
}
