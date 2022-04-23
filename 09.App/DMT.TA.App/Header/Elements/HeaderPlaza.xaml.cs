﻿#region Using

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

//using NLib.Services;
//using DMT.Configurations;
using DMT.Services;
using DMT.Models;

#endregion

namespace DMT.Controls.Header
{
    /// <summary>
    /// Interaction logic for HeaderPlaza.xaml
    /// </summary>
    public partial class HeaderPlaza : UserControl
    {
        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public HeaderPlaza()
        {
            InitializeComponent();
        }

        #endregion

        #region Internal Variables

        //private HeaderBarService service = HeaderBarService.Instance;

        #endregion

        #region Loaded/Unloaded

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtPlazaId.Visibility = Visibility.Collapsed;

            UpdateUI();

            //if (null != service) service.Register(this.UpdateUI);
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            //if (null != service) service.Unregister(this.UpdateUI);
        }

        #endregion
        /*
        private PlazaInfoConfig Config
        {
            get
            {
                if (null == service) return null;
                return service.PlazaInfo;
            }
        }
        */
        private void UpdateUI()
        {
            var tsb = TSB.GetCurrent().Value();
            Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(() =>
            {
                if (null != tsb)
                {
                    txtPlazaId.Text = "รหัสด่าน : " + tsb.TSBId;
                    txtPlazaName.Text = "ชื่อด่าน : " + tsb.TSBNameTH;
                }
                else
                {
                    txtPlazaId.Text = "รหัสด่าน : ";
                    txtPlazaName.Text = "ชื่อด่าน : ";
                }
            }));
        }
    }
}
