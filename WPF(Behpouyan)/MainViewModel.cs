using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_Behpouyan_
{
    public class MainViewModel
    {
        //public ObservableCollection<Tanker> TankersObject = new ObservableCollection<Tanker>();

        public Tanker GetTanker { get; set; }


        public MainViewModel()
        {
            GetTanker = new Tanker();
            TankerContext _context = new TankerContext("Tank");
            _context.Database.CreateIfNotExists();
           GetTanker =  _context.tankers.Find(3);
            


        }

    
    }
}
