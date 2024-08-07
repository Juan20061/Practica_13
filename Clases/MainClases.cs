using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3716370Practica13.Clases
{

    public partial class MainClases : ObservableObject
    {
        [ObservableProperty]
        private double mun1;

        [ObservableProperty]
        private double mun2;

        [ObservableProperty]
        private double rel;

        [RelayCommand]
        public void Sumar()
        {

            Rel = Mun1 + Mun2;
           
        }
    }
}
