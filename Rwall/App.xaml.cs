﻿using Rwall.Shared;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Rwall
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //We use this mutex to check to see if the app is already running.
        Mutex m_mutex;

        protected override void OnStartup(StartupEventArgs e)
        {
            //if app is already running, don't start up another instance! (unless we are debugging)
            m_mutex = new Mutex(false, Consts.AppName);
         
#if !DEBUG
            if (!m_mutex.WaitOne(0, false))
            {            
                MessageBox.Show(Consts.AppName + " is already running.", Consts.AppErrorMessageTitle, System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);

                m_mutex.Dispose();
                Application.Current.Shutdown();
            }
#endif

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            //Make sure we get rid of the app mutex!
            m_mutex.Dispose();
            base.OnExit(e);
        }
    }
}
