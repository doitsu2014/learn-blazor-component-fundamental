using System;
using Microsoft.AspNetCore.Components;

namespace Client.Shared
{
    public partial class Alert
    {
        private bool show;
        [Parameter]
        public bool Show
        {
            get => this.show;
            set
            {
                this.show = value;
                ShowChanged?.Invoke(this.show);
            }
        }

        [Parameter]
        public Action<bool> ShowChanged { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        private void DismissAlert() => Show = false;
    }
}