using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataBinding.Models
{
    public class Fruit : INotifyPropertyChanged
    {
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string name;

        public string Name
        {
            get { return name; }
            set 
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool isSweet;

        public bool IsSweet
        {
            get { return isSweet; }
            set
            {
                if (isSweet != value)
                {
                    isSweet = value;
                    OnPropertyChanged();
                }
            }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set 
            {
                if (weight != value)
                {
                    weight = value;
                    OnPropertyChanged();
                }
            }
        }


        public override string ToString() => Name;
    }
}
