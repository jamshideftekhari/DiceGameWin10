using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DiceWin10.Annotations;
using DiceWin10.Model;
using DiceWin10.Common;


namespace DiceWin10.ViewModel
{
    class GroupPageViewModel : INotifyPropertyChanged
    {
        private Groups _g1;
        static Random r = new Random();
        private string _groupName, _groupSign;
        public RelayCommand RandomGroup { get; set; }


        public Groups G1
        {
            get { return _g1;}
            set { _g1 = value; }
        }

        public string GroupName
        {
            get { return _groupName; }
            set
            {
                _groupName = value;
                OnPropertyChanged();
            }
        }
        public string GroupSign
        {
            get { return _groupSign; }
            set
            {
                _groupSign = value;
                OnPropertyChanged();
            }
        }
        public void FindRandomGroup()
        {
            _g1=new Groups(r);
            _g1.RandomGroup();
            GroupName = _g1.GetFaceValue();
            GroupSign = _g1.GetSignValue();
        }

        public GroupPageViewModel()
        {
            RandomGroup = new RelayCommand(FindRandomGroup);
        }
        



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
