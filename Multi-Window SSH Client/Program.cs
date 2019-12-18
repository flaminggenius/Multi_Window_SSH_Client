﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace Multi_Window_SSH_Client {
    static class Program {
        public static AppContainer container = new AppContainer();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //AppContainer container = new AppContainer();

            // Add the initial Tab
            container.Tabs.Add(
                // Our First Tab created by default in the Application will have as content the Form1
                new TitleBarTab(container) {
                    Content = new Main {
                        Text = "SSH Instance"
                    }
                }
            );

            // Set initial tab the first one
            container.SelectedTabIndex = 0;

            // Create tabs and start application
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);
        }
    }
}
