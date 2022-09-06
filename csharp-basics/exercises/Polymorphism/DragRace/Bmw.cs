using System;

namespace DragRace
{
    public class Bmw : ICar
    {
        private int _currentSpeed = 0;

        public void SpeedUp() 
        {
            _currentSpeed += 5;
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
            Console.WriteLine("Rrrrrrr.....");
        }

        public int CurrentSpeed => _currentSpeed;
    }
}