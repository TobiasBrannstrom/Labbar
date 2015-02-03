using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kylskåp
{
    public class Cooler
    {
        private decimal _insideTemperature;
        private decimal _targetTemperature;
        private const decimal OutsideTemperature = 23.7M;

        public bool DoorIsOpen { get; set; }

        public decimal InsideTemperature
        {
            get
            {
                return _insideTemperature;
            }
            private set
            {
                if (value < 0m || value > 45m)
                {
                    throw new ArgumentException();                   
                }
                _insideTemperature = value;
            }
        }

        public bool IsOn { get; set; }

        public decimal TargetTemperature
        {

            get
            {
                return _targetTemperature;
            }
            private set
            {
                if (value < 0m || value > 20m)
                {
                    throw new ArgumentException();
                }
                _targetTemperature = value;
            }

        }

        public Cooler()
            : this(0m, 0m)
        {
        }
        public Cooler(decimal insideTemperature, decimal targetTemperature)
            : this(insideTemperature, targetTemperature, false, false)
        {
        }

        public Cooler(decimal temperature, decimal targetTemperature, bool isOn, bool doorIsOpen)
        {
            InsideTemperature = temperature;
            TargetTemperature = targetTemperature;
            IsOn = isOn;
            DoorIsOpen = doorIsOpen;
        }

        public void Tick()
        {
            // På med stängd dörr
            if (IsOn == true && DoorIsOpen == false)
            {
                _insideTemperature -= 0.2m;

                if (_insideTemperature <= 4)
                {
                    _insideTemperature = 4m;
                } //  detta känns klumpigt men det ger rätt utskrivning
            }

            // På med öppen dörr
            else if (IsOn == true && DoorIsOpen == true)
            {
                _insideTemperature += 0.2m;
                if (_insideTemperature >= OutsideTemperature)
                {
                    _insideTemperature = OutsideTemperature;
                }
            }

            // Av med öppen dörr
            else if (IsOn == false && DoorIsOpen == true)
            {
                _insideTemperature += 0.5m;
                if (_insideTemperature >= OutsideTemperature)
                {
                    _insideTemperature = OutsideTemperature;
                } // detta känns klumpigt men det ger rätt utskrivning
            }

            // Av med stängd dörr
            else if (IsOn == false && DoorIsOpen == false)
            {
                _insideTemperature += 0.1m;
                if (_insideTemperature >= OutsideTemperature)
                {
                    _insideTemperature = OutsideTemperature;
                }
            }
          
        }

        public override string ToString()
        {
            string on = IsOn ? "PÅ" : "AV";
            string open = DoorIsOpen ? "Öppet" : "Stängt";

            return String.Format("[{0}] : {1:F1}°C : ({2:F1}°C) - {3}",
            on,
            _insideTemperature,
            _targetTemperature,
            open
            );
        }
    }
}
