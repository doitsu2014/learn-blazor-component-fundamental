using System;
using Microsoft.AspNetCore.Components;

namespace ComponentTutorial.Client.Shared
{
    public partial class Alert
    {
        [Parameter] public bool Show { get; set; }

        [Parameter] public EventCallback<bool> ShowChanged { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        public void DismissAlert()
        {
            Show = false;
            ShowChanged.InvokeAsync(this.Show);
        }
    }
}