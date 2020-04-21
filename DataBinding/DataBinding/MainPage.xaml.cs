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
        private ObservableCollection<Fruit> fruits;
        public MainPage()
        {
            InitializeComponent();
            //fruit = new Fruit { Name = "Apple" };
            //this.BindingContext = fruit;
            fruits = new ObservableCollection<Fruit>();
            fruits.Add(new Fruit {Weight = 0.1, Name = "Apple", IsSweet = true });
            fruits.Add(new Fruit {Weight = 0.2, Name = "Banana", IsSweet = false });
            fruits.Add(new Fruit {Weight = 0.3, Name = "Cherry", IsSweet = false });
            fruits.Add(new Fruit {Weight = 0.4, Name = "Durian", IsSweet = true });

            list1.ItemsSource = fruits;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //fruit.Name = "Banana";
            //list1.ItemsSource = new string[] { "Alfa", "Bravo", "Charlie", "Delta" };
            fruits.Add(new Fruit { Name = "Ebanana", IsSweet = true, Weight = 0.5 });
        }
    }
}
