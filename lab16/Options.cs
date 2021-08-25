using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab16
{
    public partial class Options : Form
    {
        private int colony;
        private int viruses;

        public Options(int population, int countOfviruses)
        {
            InitializeComponent();
            colony = population;
            viruses = countOfviruses;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (isRandomOptions.Checked)
            {
                (new City(colony, viruses)).Show();
            }
            else
            {
                int[] powers = new int[viruses];
                int[] speeds = new int[viruses];
                int count = 0;
                while(count < viruses)
                {
                    switch (count)
                    {
                        case 0:
                            powers[count] = (int)strength1.Value;
                            speeds[count] = (int)speed1.Value;
                            break;
                        case 1:
                            powers[count] = (int)strength2.Value;
                            speeds[count] = (int)speed2.Value;
                            break;
                        case 2:
                            powers[count] = (int)strength3.Value;
                            speeds[count] = (int)speed3.Value;
                            break;
                        case 3:
                            powers[count] = (int)strength4.Value;
                            speeds[count] = (int)speed4.Value;
                            break;
                        case 4:
                            powers[count] = (int)strength5.Value;
                            speeds[count] = (int)speed5.Value;
                            break;
                        case 5:
                            powers[count] = (int)strength6.Value;
                            speeds[count] = (int)speed6.Value;
                            break;
                        case 6:
                            powers[count] = (int)strength7.Value;
                            speeds[count] = (int)speed7.Value;
                            break;
                        case 7:
                            powers[count] = (int)strength8.Value;
                            speeds[count] = (int)speed8.Value;
                            break;
                        case 8:
                            powers[count] = (int)strength9.Value;
                            speeds[count] = (int)speed9.Value;
                            break;
                        case 9:
                            powers[count] = (int)strength10.Value;
                            speeds[count] = (int)speed10.Value;
                            break;
                        default:
                            break;
                    }
                    count++;
                }
                (new City(colony, viruses, powers, speeds)).Show();
            }
            
        }
    }
}
