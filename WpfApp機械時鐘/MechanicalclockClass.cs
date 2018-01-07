using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp機械時鐘
{
    class MechanicalclockClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int SecondAngle { get; private set; }
        public int MinuteAngle { get; private set; }
        public int HourAngle { get; private set; }


    }
}
