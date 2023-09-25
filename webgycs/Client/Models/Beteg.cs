using System.ComponentModel;
using ViewModels.BaseClass;

namespace TTIProject.Model
{
    public class Beteg : ViewModelBase
    {
       
        private string _nev;
       
        private double _suly;
       
        private double _magassag;

       
        public Beteg()
        {
            _nev = string.Empty;
            _suly = 60;
            _magassag = 1.6;
        }

       
        public string Nev
        {
            get => _nev;
            set => SetValue(ref _nev, value);
        }
        public string Suly
        {
            get => _suly.ToString();
            set => SetValue(ref _suly, Convert.ToDouble(value));
        }

        public string Magassag
        {
            get => _magassag.ToString();
            set => SetValue(ref _magassag, Convert.ToDouble(value));
        }

       
        public double TTI
        {
            get
            {
                double tti = _suly / Math.Pow(_magassag, 2);
                double roundedTTI = Math.Round(tti, 2);
                return roundedTTI;
            }
        }

        public string BetegAdatok
        {
            get
            {
                return _nev + " beteg testőmeg indexe: " + TTI;
            }
        }

        public void Compute()
        {
            OnPropertyChanged(nameof(TTI));
            OnPropertyChanged(nameof(BetegAdatok));
        }
    }
}