﻿#region Using

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

//using DMT.Configurations;
using DMT.Services;

#endregion

namespace DMT.Controls.StatusBar
{
    /// <summary>
    /// Interaction logic for TSBCouponSyncStatus.xaml
    /// </summary>
    public partial class TSBCouponSyncStatus : UserControl
    {
        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public TSBCouponSyncStatus()
        {
            InitializeComponent();
        }

        #endregion

        #region Loaded/Unloaded

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateUI();
            CouponSyncService.Instance.OnProgress += Instance_OnProgress;
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            CouponSyncService.Instance.OnProgress -= Instance_OnProgress;
        }

        #endregion

        #region Sync Handlers

        private void Instance_OnProgress(object sender, ProgressEventArgs e)
        {
            // Focus on search textbox.
            Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(() =>
            {
                progress.Maximum = e.Max;
                progress.Value = e.Current;
            }));
        }

        #endregion

        private void UpdateUI()
        {

        }
    }
}
