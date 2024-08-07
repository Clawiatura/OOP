using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace Events
{
    internal class Keyboard
    {
        public event Action<char> KeyPressed;
        public  void SimulateKeyPress(char key)
        {
            KeyPressed.Invoke(key);
        }
        public void PressA() => SimulateKeyPress('A');
        public void PressB() => SimulateKeyPress('B');
        public void Press1() => SimulateKeyPress('1');
    }

}
