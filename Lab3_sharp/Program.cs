using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab3_sharp.View;
using System.Windows.Forms;

namespace Lab3_sharp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static MainForm f1;
        public static RoomForm f2;
        public static int a, b = 0;
        public static int Instr = 0;
        public static int Worker = 0;
        public static List<int> rooms = new List<int>();
        public static List<int> workers = new List<int>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
