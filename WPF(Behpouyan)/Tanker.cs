using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Behpouyan_
{
    public class Tanker : ObserVableObject
    {
        private int id;
        private int amount;
        private double height;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChang("Id");
            }
        }

        public int Amount
        {
            get { return amount; }
            set
            {
                amount = value;
                OnPropertyChang("Amount");
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                height = value;
                OnPropertyChang("Height");
            }

        }
    }
}
