using Microsoft.AspNetCore.Components;
using SharedLibrary;

namespace WebAssBlazor.Pages
{
    public partial class TranieeEdit
    {
		[Parameter]
		public int TraineeId { get; set; }

		public Treniee CurTre { get; set; }

		public bool Saved;

		protected override Task OnInitializedAsync()
		{
			Saved = false;
            CurTre = MockContext.Treniees.FirstOrDefault(tr => tr.TraineeId == TraineeId);


			return base.OnInitializedAsync();
		}

		protected void HandleValidSubmit()
		{
			var editedtre = MockContext.Treniees.FirstOrDefault(tr => tr.TraineeId == TraineeId);
			editedtre.TraineeName = CurTre.TraineeName;
			editedtre.Birthdate = CurTre.Birthdate;
			editedtre.MobileNo = CurTre.MobileNo;
			editedtre.Gender = CurTre.Gender;
			editedtre.IsGraduated = CurTre.IsGraduated;
			editedtre.Email = CurTre.Email;
			Saved = true;
		}

		protected void HandleInvalidSubmit()
		{
			Saved = false;
		}
	}
}
