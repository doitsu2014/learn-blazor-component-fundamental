using System;
using System.Threading;
using Microsoft.AspNetCore.Components;

namespace ComponentTutorial.Client.Shared
{
    public class Timer : ComponentBase
    {
        public Timer()
        {
        }

        [Parameter]
        public double TimeInSeconds { get; set; }

        [Parameter]
        public Action Tick { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            var timer = new System.Threading.Timer
            (
                callback: (_) => InvokeAsync(() => Tick?.Invoke()),
                state: null,
                dueTime: TimeSpan.FromSeconds(TimeInSeconds),
                period: Timeout.InfiniteTimeSpan
            );
        }
    }
}