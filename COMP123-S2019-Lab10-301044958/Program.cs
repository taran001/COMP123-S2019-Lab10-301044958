﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301044958
{
    public static class Program
    {
        public static StartForm startform;
        public static MainForm mainform;
        public static EndForm endform;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startform = new StartForm();
            mainform = new MainForm();
            endform = new EndForm();
            Application.Run(new StartForm());       
        }
        
    }
}
