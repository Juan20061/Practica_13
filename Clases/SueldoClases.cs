using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3716370Practica13.Clases
{
    public partial class SueldoClases:ObservableObject
    {


        [ObservableProperty]
        public string sueldo;

        [ObservableProperty]
        public string aumento ;




        [RelayCommand]
        public void AumentoEm()
        {
            if (decimal.TryParse(Sueldo, out decimal Pagosueldo))
            {
                decimal PagoAc = Pagosueldo < 1000 ? Pagosueldo * 1.15m : Pagosueldo * 1.12m;
                Aumento = PagoAc.ToString();
            }   

           
        }

    }
}
