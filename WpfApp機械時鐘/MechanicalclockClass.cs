﻿using System;
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

        public void SetTime(DateTime time)
        {
            this.SecondAngle = time.Second * 360 / 60;
            this.MinuteAngle = time.Minute * 360 / 60;
            this.HourAngle = (time.Hour % 12) * 360 / 12;

            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.SecondAngle)));
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.MinuteAngle)));
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.HourAngle)));
        }


    }
}
