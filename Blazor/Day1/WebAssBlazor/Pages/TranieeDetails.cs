using Microsoft.AspNetCore.Components;
using SharedLibrary;

namespace WebAssBlazor.Pages
{
    public partial class TranieeDetails
    {

        [Parameter]
        public int TraineeId { get; set; }

        public Treniee CurTre { get; set; }

        protected override Task OnInitializedAsync()
        {
            CurTre = MockContext.Treniees.FirstOrDefault(tr => tr.TraineeId == TraineeId);

            return base.OnInitializedAsync();
        }
    }
}
