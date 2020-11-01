using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace LearningBlazorWeb.Client.Shared
{
    public class FormWatcher : ComponentBase
    {
        private EditContext _editContext;

        [CascadingParameter]
        public EditContext EditContext
        {
            get => _editContext;
            set 
            {
                this._editContext = value;
                this._editContext.OnFieldChanged += async(sender, e)
                    => await FieldChanged.InvokeAsync(e.FieldIdentifier.FieldName);
            }
        }

        [Parameter]
        public EventCallback<string> FieldChanged { get; set; }

        public bool Validate() => _editContext?.Validate() ?? false;
    }
}