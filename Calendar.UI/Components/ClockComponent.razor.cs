using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.UI.Components
{
    public partial class ClockComponent
    {

        public string HourPoint { get; private set; }
        public string MinutePoint { get; private set; }
        public string SecondPoint { get; private set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            HourPoint = $"{DateTime.Now.Hour % 12 * 30 + DateTime.Now.Minute / 2}";
            MinutePoint = $"{DateTime.Now.Minute * 6 }";
            SecondPoint = $"{DateTime.Now.Second * 6}";
        }
    }
}
