using System.Drawing;

namespace lab16
{
    class Cells
    {
        public Location Location { get; set; }
        public Strength Strength { get; set; }
        public Color Color { get; set; }
        public bool IsPlagued { get; set; }
        public bool IsActivated { get; set; }
        public Velocity Velocity { get; set; }

        public Cells(Color color, int row, int column)
        {
            Color = color;
            IsPlagued = false;
            Strength = new Strength(0);
            Velocity = new Velocity(0);
            IsActivated = false;
            Location = new Location(row, column);
        }

        public void PatientZero(Color color, int strength, int speed)
        {
            Color = color;
            IsPlagued = true;
            IsActivated = true;
            Strength = new Strength(strength);
            Velocity = new Velocity(speed);
        }

        public void Virus(Color color, Strength strength, Velocity velocity)
        {
            if (Strength.Power < strength.Power)
            {
                Color = color;
                IsPlagued = true;
                IsActivated = true;
                Strength = strength;
                Velocity = velocity;
            }
        }

        public void Deactivate()
        {
            IsActivated = false;
        }

        public void Activate()
        {
            IsActivated = true;
        }
    }
}
