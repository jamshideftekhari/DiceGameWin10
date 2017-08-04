using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DiceGame;
using DiceWin10.Common;


//namespace WinDiceGame.ViewModel
namespace DiceWin10.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        private Die _d1;
        private Die _d2;
        static Random r = new Random();
        private int _r1, _r2, _sum;
        private string _mytext;


        public string MyText
        {
            get { return _mytext; }
            set
            {
                _mytext = value;
                OnPropertyChanged();
            }
        }

        public int Sum
        {
            get { return _sum; }
            set
            {
                _sum = value;
                OnPropertyChanged();
            }
        }
        public int R1
        {
            get { return _r1; }
            set
            {
                _r1 = value;
                OnPropertyChanged();
            }
        }

        public int R2
        {
            get { return _r2; }
            set
            {
                _r2 = value;
                OnPropertyChanged();
            }
        }

        public Die D1
        {
            get { return _d1; }
            set { _d1 = value; }
        }

        public Die D2
        {
            get { return _d2; }
            set
            {
                _d2 = value;
                 
            }
        }
        public RelayCommand RollDice { get; set; }

        public void DoRollDice()
        {
            _d1 = new Die(r);
            _d2 = new Die(r);

            _d1.roll();
            _d2.roll();
            R1 = _d1.getFaceValue();
            R2 = _d2.getFaceValue();
            Sum = R1 + R2;
            if (Sum == 7)
                MyText = "HUUUUURRRRRAAAAA";
            else
            {
                MyText = "";
            }
            OnPropertyChanged();
        }
        public MainPageViewModel()
        {
            //_d1 = new Die(r);
            //_d2 = new Die(r);

            //_d1.roll();
            //_d2.roll();
            //R1 = _d1.getFaceValue();
            //R2 = _d2.getFaceValue();
            RollDice = new RelayCommand(DoRollDice);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public Die Die
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
