using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class SwitchFinct
    {
        private bool _isOn = false;
        public delegate void Activation(bool onOrOff);
        public event Activation OnPress;

        public void Press()
        {
            _isOn = !_isOn;
            OnPress.Invoke(_isOn);
        }
    }
}
