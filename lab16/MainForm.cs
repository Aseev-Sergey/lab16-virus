using System;
using System.Windows.Forms;

namespace lab16
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            if ((int)virus.Value >= (int)population.Value * (int)population.Value)
            {
                statusBox.Text = "Заражение за 0 циклов";
            }
            else
            {
                (new Options((int)population.Value, (int)virus.Value)).Show();
            }
        }
    }
}
