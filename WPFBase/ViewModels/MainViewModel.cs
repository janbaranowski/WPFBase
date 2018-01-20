using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFBase.Utils;

namespace WPFBase.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private RelayCommand calculateCommand;

        public RelayCommand CalculateCommand
        {
            get
            {
                if (calculateCommand == null)
                    calculateCommand = new RelayCommand(o => Calculate(), o => CanCalculate());
                return calculateCommand;
            }
            set { calculateCommand = value; }
        }


        private double podstawa;

        public double Podstawa
        {
            get { return podstawa; }
            set { podstawa = value; }
        }
        private int wykladnik;

        public int Wykladnik
        {
            get { return wykladnik; }
            set { wykladnik = value; }
        }
        private double wynik;

        public double Wynik
        {
            get { return wynik; }
            set {
                SetProperty(ref wynik, value);
                }
        }

        public void Calculate()
        {
            Wynik = Math.Pow(Podstawa, Wykladnik);
        }
        public bool CanCalculate()
        {
            if (podstawa == 0 || wykladnik == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
