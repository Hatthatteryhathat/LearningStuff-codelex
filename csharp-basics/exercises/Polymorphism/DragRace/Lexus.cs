using System;

namespace DragRace
{
    public class Lexus : ICar, IBoost
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 6;
        }

        public void SlowDown()
        {
            _currentSpeed -= 5;
        }

        public string ShowCurrentSpeed()
        {
            return CurrentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 10;
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }

        public int CurrentSpeed => _currentSpeed;
    }
}