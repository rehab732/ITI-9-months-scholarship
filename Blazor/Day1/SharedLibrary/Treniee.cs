using System.ComponentModel.DataAnnotations;

namespace SharedLibrary
{
	public class Treniee
	{
		/*
		 * Trainee shoud have the following properties:
				- ID
				- Name
				- Gender
				- email
				- MobileNo
				- Birthdate
				- IsGraduated
		 */

		public int TraineeId { get; set; }
		[Required]
		[StringLength(30,ErrorMessage ="Treniee Name is Too long")]
		public string? TraineeName { get; set; }
		[EmailAddress]
		public string? Email { get; set; }
		public string? MobileNo { get; set; }
		public DateTime Birthdate { get; set; }

		public bool IsGraduated { get; set; }
		public Gender Gender { get; set; }

		public int TrackId { get; set; }
		public virtual Track? Track { get; set; }

	}
}