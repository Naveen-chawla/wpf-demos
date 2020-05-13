#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Windows;
using System.Windows.Input;
using System.Net;
using System.IO;
using Syncfusion.Windows.Reports.Viewer;
using Syncfusion.Windows.Reports;

namespace Syncfusion.Samples.ViewModel
{
    public class ReportViewModel
    {
        public ReportModel Report { get; set; }

        #region Constructor

        public ReportViewModel()
        {
            this.Report = new ReportModel();
            this.Report.ReportPath = this.GetFullPath("DrilThrough.rdlc");
        }

        public void Loaded(object sender, RoutedEventArgs e)
        {
            Window mainWindow = sender as Window;
            Syncfusion.Windows.Reports.Viewer.ReportViewer viewer = mainWindow.FindName("viewer") as Syncfusion.Windows.Reports.Viewer.ReportViewer;
            viewer.DataSources.Add(new ReportDataSource("IndividualCustomerSales", IndividualCustomer.CustomerSales.GetData()));
            viewer.DataSources.Add(new ReportDataSource("StoreSales", IndividualCustomer.StoreSales.GetData()));
            viewer.RefreshReport();
        }

        private string GetFullPath(string report)
        {           
            string templateDirectory = @"../../../../../../Common/Data/ReportTemplate/RDLC";
            string dir = new DirectoryInfo(templateDirectory).FullName;
            return System.IO.Path.Combine(dir, report);
        }

        #endregion
    }
}
