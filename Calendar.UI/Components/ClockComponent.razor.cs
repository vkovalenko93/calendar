using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace Calendar.UI.Components
{
    public partial class ClockComponent : IDisposable
    {

        public double HourPoint { get; set; }
        public double MinutePoint { get; set; }
        public double SecondPoint { get; set; }

        private Timer _timer;
        #region Private Methodos
        
        private void SetCurrentTime(object sender, ElapsedEventArgs e)
        {
            var currentTime = e.SignalTime;
            HourPoint = currentTime.Hour % 12 * 30 + currentTime.Minute / 2;
            MinutePoint = currentTime.Minute * 6;
            SecondPoint = currentTime.Second * 6;
            Console.WriteLine($"{currentTime}, {HourPoint}, {MinutePoint}, {SecondPoint}");
            InvokeAsync(StateHasChanged);
        }

        #endregion

        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            _timer = new Timer(1000);
            _timer.Elapsed += SetCurrentTime;
            _timer.Start();
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
