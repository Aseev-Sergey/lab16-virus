using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab16
{
    public partial class City : Form
    {
        private Cells[,] cells;
        private const int WHITE = 0;
        private const int ONE = 1;
        private const int FIRSTELEMENT = 0;
        private readonly int MAXELEMENT;
        private int cycle = 0;
        private Color topColor;

        public City(int population, int countOfViruses)
        {
            InitializeComponent();
            MAXELEMENT = population;
            CreateTable(MAXELEMENT);
            Random rand = new Random();
            int[,] location = new int[countOfViruses, 2];
            int strain = 0, locRow = 0, locCol = 0;
            while (strain < countOfViruses)
            {
                int row = rand.Next(0, MAXELEMENT);
                int column = rand.Next(0, MAXELEMENT);
                if (cells[row, column].IsActivated)
                {
                    continue;
                }
                location[locRow, locCol] = row;
                location[locRow, locCol + ONE] = column;
                cells[row, column].PatientZero(Program.colors[strain + 1], rand.Next(1,101), rand.Next(1,6));
                metropolis.Rows[row].Cells[column].Style.BackColor =
                    cells[row, column].Color;
                strain++;
                locRow++;
            }
            int maxStrength = 0;
            for (int row = 0; row < location.GetLength(0); row++)
            {
                cells[location[row, locCol], location[row, locCol + ONE]].Deactivate();
                if (maxStrength < cells[location[row, locCol], location[row, locCol + ONE]].Strength.Power)
                {
                    maxStrength = cells[location[row, locCol], location[row, locCol + ONE]].Strength.Power;
                    topColor = cells[location[row, locCol], location[row, locCol + ONE]].Color;
                }
            }
            infection.Enabled = true;
        }

        public City(int population, int countOfViruses, int[] strength, int[] speed)
        { 
            InitializeComponent();
            MAXELEMENT = population;
            CreateTable(MAXELEMENT);
            Random rand = new Random();
            int[,] location = new int[countOfViruses, 2];
            int strain = 0, locRow = 0, locCol = 0;
            while(strain < countOfViruses)
            {
                int row = rand.Next(0, MAXELEMENT);
                int column = rand.Next(0, MAXELEMENT);
                if (cells[row, column].IsActivated)
                {
                    continue;
                }
                location[locRow, locCol] = row;
                location[locRow, locCol + ONE] = column;
                cells[row, column].PatientZero(Program.colors[strain + 1], strength[strain], speed[strain]);
                metropolis.Rows[row].Cells[column].Style.BackColor =
                    cells[row, column].Color;
                strain++;
                locRow++;
            }
            int maxStrength = 0;
            for(int row = 0; row < location.GetLength(0); row++)
            {
                cells[location[row, locCol], location[row, locCol + ONE]].Deactivate();
                if(maxStrength < cells[location[row, locCol], location[row, locCol + ONE]].Strength.Power)
                {
                    maxStrength = cells[location[row, locCol], location[row, locCol + ONE]].Strength.Power;
                    topColor = cells[location[row, locCol], location[row, locCol + ONE]].Color;
                }
            }
            infection.Enabled = true;
        }

        private void Metropolis_ColumnAdded(object sender, DataGridViewColumnEventArgs current)
        {
            current.Column.Width = 10;
        }

        public void CreateTable(int population)
        {
            metropolis.RowCount = population;
            metropolis.ColumnCount = population;
            cells = new Cells[population, population];
            for(int row = 0; row < population; row++)
            {
                for(int column = 0; column < population; column++)
                {
                    cells[row, column] = new Cells(Program.colors[WHITE], row, column);
                }
            }
        }
        
        private void Contamination(ref Cells[,] colony, ref Cells virus)
        {
            Location left, right, top, bottom;
            left = new Location(virus.Location.Row, virus.Location.Column - ONE);
            right = new Location(virus.Location.Row, virus.Location.Column + ONE);
            top = new Location(virus.Location.Row - ONE, virus.Location.Column);
            bottom = new Location(virus.Location.Row + ONE, virus.Location.Column);
            if (IsLeftUpperAngle(virus.Location))
            {
                colony[bottom.Row, bottom.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                metropolis.Rows[bottom.Row].Cells[bottom.Column].Style.BackColor =
                    colony[bottom.Row, bottom.Column].Color;
                colony[right.Row, right.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                metropolis.Rows[right.Row].Cells[right.Column].Style.BackColor =
                    colony[right.Row, right.Column].Color;
            }
            else
            {
                if (IsRightUpperAngle(virus.Location))
                {
                    colony[bottom.Row, bottom.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                    metropolis.Rows[bottom.Row].Cells[bottom.Column].Style.BackColor =
                        colony[bottom.Row, bottom.Column].Color;
                    colony[left.Row, left.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                    metropolis.Rows[left.Row].Cells[left.Column].Style.BackColor =
                        colony[left.Row, left.Column].Color;
                }
                else
                {
                    if (IsRightLowerAngle(virus.Location))
                    {
                        colony[left.Row, left.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                        metropolis.Rows[left.Row].Cells[left.Column].Style.BackColor =
                            colony[left.Row, left.Column].Color;
                        colony[top.Row, top.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                        metropolis.Rows[top.Row].Cells[top.Column].Style.BackColor =
                            colony[top.Row, top.Column].Color;
                    }
                    else
                    {
                        if (IsLeftLowerAngle(virus.Location))
                        {
                            colony[top.Row, top.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                            metropolis.Rows[top.Row].Cells[top.Column].Style.BackColor =
                                colony[top.Row, top.Column].Color;
                            colony[right.Row, right.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                            metropolis.Rows[right.Row].Cells[right.Column].Style.BackColor =
                                colony[right.Row, right.Column].Color;
                        }
                        else
                        {
                            if (IsUpperBorder(virus.Location.Row))
                            {
                                colony[bottom.Row, bottom.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                                metropolis.Rows[bottom.Row].Cells[bottom.Column].Style.BackColor =
                                    colony[bottom.Row, bottom.Column].Color;
                                colony[right.Row, right.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                                metropolis.Rows[right.Row].Cells[right.Column].Style.BackColor =
                                    colony[right.Row, right.Column].Color;
                                colony[left.Row, left.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                                metropolis.Rows[left.Row].Cells[left.Column].Style.BackColor =
                                    colony[left.Row, left.Column].Color;
                            }
                            else
                            {
                                if (IsRightBorder(virus.Location.Column))
                                {
                                    colony[top.Row, top.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                                    metropolis.Rows[top.Row].Cells[top.Column].Style.BackColor =
                                        colony[top.Row, top.Column].Color;
                                    colony[bottom.Row, bottom.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                                    metropolis.Rows[bottom.Row].Cells[bottom.Column].Style.BackColor =
                                        colony[bottom.Row, bottom.Column].Color;
                                    colony[left.Row, left.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                                    metropolis.Rows[left.Row].Cells[left.Column].Style.BackColor =
                                        colony[left.Row, left.Column].Color;
                                }
                                else
                                {
                                    if (IsLowerBorder(virus.Location.Row))
                                    {
                                        colony[top.Row, top.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                                        metropolis.Rows[top.Row].Cells[top.Column].Style.BackColor =
                                            colony[top.Row, top.Column].Color;
                                        colony[right.Row, right.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                                        metropolis.Rows[right.Row].Cells[right.Column].Style.BackColor =
                                            colony[right.Row, right.Column].Color;
                                        colony[left.Row, left.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                                        metropolis.Rows[left.Row].Cells[left.Column].Style.BackColor =
                                            colony[left.Row, left.Column].Color;
                                    }
                                    else
                                    {
                                        if (IsLeftBorder(virus.Location.Column))
                                        {
                                            colony[top.Row, top.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                                            metropolis.Rows[top.Row].Cells[top.Column].Style.BackColor =
                                                colony[top.Row, top.Column].Color;
                                            colony[bottom.Row, bottom.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                                            metropolis.Rows[bottom.Row].Cells[bottom.Column].Style.BackColor =
                                                colony[bottom.Row, bottom.Column].Color;
                                            colony[right.Row, right.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                                            metropolis.Rows[right.Row].Cells[right.Column].Style.BackColor =
                                                colony[right.Row, right.Column].Color;
                                        }
                                        else
                                        {
                                            colony[top.Row, top.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                                            metropolis.Rows[top.Row].Cells[top.Column].Style.BackColor =
                                                colony[top.Row, top.Column].Color;
                                            colony[bottom.Row, bottom.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                                            metropolis.Rows[bottom.Row].Cells[bottom.Column].Style.BackColor =
                                                colony[bottom.Row, bottom.Column].Color;
                                            colony[right.Row, right.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                                            metropolis.Rows[right.Row].Cells[right.Column].Style.BackColor =
                                                colony[right.Row, right.Column].Color;
                                            colony[left.Row, left.Column].Virus(virus.Color, virus.Strength, virus.Velocity);
                                            metropolis.Rows[left.Row].Cells[left.Column].Style.BackColor =
                                                colony[left.Row, left.Column].Color;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private bool IsLeftUpperAngle(Location location)
        {
            return (location.Row == FIRSTELEMENT) && (location.Column == FIRSTELEMENT);
        }

        private bool IsLeftLowerAngle(Location location)
        {
            return (location.Row == MAXELEMENT - ONE) && (location.Column == FIRSTELEMENT);
        }

        private bool IsRightUpperAngle(Location location)
        {
            return (location.Row == FIRSTELEMENT) && (location.Column == MAXELEMENT - ONE);
        }

        private bool IsRightLowerAngle(Location location)
        {
            return (location.Row == MAXELEMENT - ONE) && (location.Column == MAXELEMENT - ONE);
        }

        private bool IsUpperBorder(int row)
        {
            return (row == FIRSTELEMENT);
        }

        private bool IsLowerBorder(int row)
        {
            return (row == MAXELEMENT - ONE);
        }

        private bool IsLeftBorder(int column)
        {
            return (column == FIRSTELEMENT);
        }

        private bool IsRightBorder(int column)
        {
            return (column == MAXELEMENT - ONE);
        }

        private void Infection_Tick(object sender, EventArgs e)
        {
            if (IsAllDead(cells))
            {
                infection.Enabled = false;
                DialogResult result = MessageBox.Show("Заражение за " + cycle + " циклов. Продолжить?",
                    "Успех", MessageBoxButtons.YesNo, MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    domination.Enabled = true;
                }
            }
            Tick();
        }

        private bool IsAllDead(Cells[,] colony)
        {
            for (int row = 0; row < colony.GetLength(0); row++)
            {
                for (int column = 0; column < colony.GetLength(1); column++)
                {
                    if (!colony[row, column].IsPlagued)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsOneVirus(Cells[,] colony)
        {
            for (int row = 0; row < colony.GetLength(0); row++)
            {
                for (int column = 0; column < colony.GetLength(1); column++)
                {
                    if (topColor != colony[row, column].Color)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void Domination_Tick(object sender, EventArgs e)
        {
            if (IsOneVirus(cells))
            {
                domination.Enabled = false;
                MessageBox.Show("Заражение за " + cycle + " циклов.", "Успех");
            }
            Tick();
        }

        private void Tick()
        {
            for (int row = 0; row < cells.GetLength(0); row++)
            {
                for (int column = 0; column < cells.GetLength(1); column++)
                {
                    if(cells[row, column].Velocity.Speed != 0 && cycle % cells[row, column].Velocity.Speed == 0)
                    {
                        if (cells[row, column].IsPlagued)
                        {
                            if (!cells[row, column].IsActivated)
                            {
                                cells[row, column].Activate();
                                Contamination(ref cells, ref cells[row, column]);
                            }
                        }
                    }
                }
            }
            for (int row = 0; row < cells.GetLength(0); row++)
            {
                for (int column = 0; column < cells.GetLength(1); column++)
                {
                    cells[row, column].Deactivate();
                }
            }
            cycle++;
        }
    }
}
