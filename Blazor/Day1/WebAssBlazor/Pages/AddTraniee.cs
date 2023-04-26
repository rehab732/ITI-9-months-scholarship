using Microsoft.AspNetCore.Components;
using SharedLibrary;

namespace WebAssBlazor.Pages
{
    public partial class AddTraniee
    {
        Treniee trainee = new Treniee();

        public void Valid()

        {
            MockContext.Treniees.Add(trainee);
            NavManager.NavigateTo("/tranieeoverview");


        }


        /*Treniee CurTre;

        public bool Saved;
        protected override void OnInitialized()
        {
            CurTre=new Treniee();
            base.OnInitialized();
        }
        protected override Task OnInitializedAsync()
        {
            Saved = false;
           // CurTre = MockContext.Treniees.FirstOrDefault(tr => tr.TraineeId == TraineeId);


            return base.OnInitializedAsync();
        }

        protected void HandleValidSubmit()
        {
            MockContext.Treniees.Add(CurTre);
            Saved = true;
        }

        protected void HandleInvalidSubmit()
        {
            Saved = false;
        }
    }*/
}
}
