#define SINGELTON_APP

#region Using

using System;
using System.Windows;
/*
using NLib;
using NLib.Logs;

using DMT.Configurations;
using DMT.Models;
using DMT.Models.ExtensionMethods;
using DMT.Services;
*/
#endregion

namespace DMT
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region OnStartup

        /// <summary>
        /// OnStartup.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //Console.WriteLine("OnStartUp");

            if (null != AppDomain.CurrentDomain)
            {
                if (null != System.Threading.Thread.CurrentContext)
                {
                    Console.WriteLine("Thread CurrentContext is not null.");
                }
            }
        }

        #endregion

        #region OnExit

        /// <summary>
        /// OnExit.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnExit(ExitEventArgs e)
        {
            //Console.WriteLine("OnExit");

            base.OnExit(e);
        }

        #endregion
    }
}
