using System;

namespace lab16
{
    class Strength
    {
        public int Power { get; set; }

        public Strength()
        {
            Power = new Random().Next(1, 101);
        }

        public Strength(int power)
        {
            Power = power;
        }
    }
}
