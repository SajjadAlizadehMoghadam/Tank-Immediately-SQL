using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_Behpouyan_
{
    public class BrushesFill : ObserVableObject
    {
        private Brush brush;

        public Brush Brush
        {

            get
            {
                if (brush == null)
                {
                    return Brushes.Green;
                }
                else
                {
                    return brush;
                }
            }
            set
            {

                brush = value;
                OnPropertyChang("Brush");
            }

        }
    }
}
