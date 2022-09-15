namespace DragRace
{
    public interface ICar
    {
        int CurrentSpeed { get; }
        
        void SlowDown();

        void SpeedUp();

        string ShowCurrentSpeed();

        void StartEngine();
    }
}