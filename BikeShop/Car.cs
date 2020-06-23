using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BikeShop
{
    public class Human
    {
        public string FirstName { get; set; }
        public bool HasDrivingLicense { get; set; }
    }
    
    
    public class Car
    {
        public double Speed { get; set; }

        /* public double Speed
         * get
         * {
         *      return speed;
         * }
         * Set
         * {
         *      speed = value;
         * }
         * => public double Speed { get; set; } 이 코드와 동일
         */
        public Color Color { get; set; }

        public Human Driver { get; set; }
    }
}
