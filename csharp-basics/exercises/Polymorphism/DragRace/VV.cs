using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    internal class VV : ICar
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 3;
        }

        public void SlowDown()
        {
            _currentSpeed -= 5;
        }

        public string ShowCurrentSpeed()
        {
            return CurrentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Brrr.......");
        }

        public int CurrentSpeed => _currentSpeed;
    }
}
