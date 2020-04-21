using DataBinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBinding
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private Fruit fruit;
        private ObservableCollection<string> fruits;
        public MainPage()
        {
            InitializeComponent();
            //fruit = new Fruit { Name = "Apple" };
            //this.BindingContext = fruit;
            fruits = new ObservableCollection<string>();
            fruits.Add("Alfa");
            fruits.Add("Bravo");
            fruits.Add("Charlie");
            fruits.Add("Delta");

            list1.ItemsSource = fruits;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //fruit.Name = "Banana";
            //list1.ItemsSource = new string[] { "Alfa", "Bravo", "Charlie", "Delta" };
            fruits.Add("Echo");
        }
    }
}
