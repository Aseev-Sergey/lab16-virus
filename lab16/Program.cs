using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab16
{
    

    static class Program
    {

        public static readonly Color[] colors =
        {
        Color.White,
        Color.Red,
        Color.Blue,
        Color.Green,
        Color.Yellow,
        Color.Brown,
        Color.Gray,
        Color.Orange,
        Color.Purple,
        Color.GreenYellow,
        Color.Aqua
        };

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
