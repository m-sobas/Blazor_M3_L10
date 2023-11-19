using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Blazor_M3_L10.Pages
{
    public partial class BackgroundColor
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        private async Task ChangeBackgroundColor()
        {
            await JSRuntime.InvokeVoidAsync("changeBackgroundColor");
        }
    }
}
