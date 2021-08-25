using System;

namespace lab16
{
    class Velocity
    {
        public int Speed { get; set; }

        public Velocity()
        {
            Speed = new Random().Next(0, 6);
        }

        public Velocity(int speed)
        {
            Speed = speed;
        }
    }
}
