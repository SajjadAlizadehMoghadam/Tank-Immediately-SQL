using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Behpouyan_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Tanker> TankersObject = new ObservableCollection<Tanker>();


        MainViewModel viewModel = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();

            using (var _con = new TankerContext("Tank"))
            {
                var tank = _con.tankers.ToList();
                foreach (var t in tank)
                {
                    TankersObject.Add(new Tanker()
                    {
                        Height = t.Height,
                        Amount = t.Amount
                    });
                }

            }
            lstBox.ItemsSource = TankersObject;
            StartUpdate();
        }

        public async void StartUpdate()
        {
            while (true)
            {
                using (var _con = new TankerContext("Tank"))
                {
                    var tank = _con.tankers.ToList();
                    for (int i = 0; i < tank.Count; i++)
                    {
                        TankersObject[i].Height = tank[i].Height;
                        TankersObject[i].Amount = tank[i].Amount;
                    }
                }

                lstBox.Items.Refresh();
                await Task.Delay(1000);
            }
        }


    }
}
