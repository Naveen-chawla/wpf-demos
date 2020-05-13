#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Threading;

namespace ChartAutoScrollingDemo
{
    public class ProductDetails : ObservableCollection<Product>
    {
        private DispatcherTimer timer;
        DateTime currentDate;
        Random rand;

        public ProductDetails()
        {
            timer = new DispatcherTimer();
            currentDate = new DateTime();
            rand= new Random();
            DateTime dt = DateTime.Now;

            for (int i = 11; i < 140; i++)
            {
                this.Add(new Product { Rate = rand.Next(110, 240), Speed = dt });
                dt = dt.AddMinutes(1);
            }
            
            timer.Start();
            timer.Interval = TimeSpan.FromMilliseconds(150);
            timer.Tick += new EventHandler(timer_Tick);
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            int index = this.Count - 1;

            currentDate = this[index].Speed.AddMinutes(1);

            this.Add(new Product() { Speed = currentDate, Rate = rand.Next(100, 250) });
        }
    }
}
