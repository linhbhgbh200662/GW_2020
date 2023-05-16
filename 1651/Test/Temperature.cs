using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Temperature
    {
        private double Fahrenheit;
        private double _ftemp;
        
        

        public Temperature(double ftemp)
        {
            _ftemp = ftemp; 
        }
        public void setFahrenheit(double ftemp)
            this._ftemp = ftemp;
        }
        public double getFahrenheit() 
        {
        return this._ftemp;
        }

        public double getCelsius()
        {
            return (5 / 9) * (this._ftemp - 32);
        }

        public double getKelvin()
        {
            return ((5 / 9) * (this._ftemp - 32)) + 273;
        }
    }
}