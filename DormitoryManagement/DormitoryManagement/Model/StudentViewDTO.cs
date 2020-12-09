using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagement.Model
{
	public class StudentViewDTO
	{
		public long UserId { get; set; }
		public string StudentId { get; set; }
		public string FullName { get; set; }
		public string Gender { get; set; }
		public DateTime Dob { get; set; }
		public string Ssn { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string College { get; set; }

		public StudentViewDTO(DataRow dr)
		{
			this.UserId = Convert.ToInt64(dr["USER_ID"]);
			this.StudentId = Convert.ToString(dr["STUDENT_ID"]).Trim();
			this.FullName = Convert.ToString(dr["FULL_NAME"]).Trim();
			this.Gender = Convert.ToString(dr["GENDER"]).Trim();
			this.Dob = Convert.ToDateTime(dr["DOB"]);
			this.Ssn = Convert.ToString(dr["SSN"]).Trim();
			this.PhoneNumber = Convert.ToString(dr["PHONE_NUMBER_1"]).Trim();
			this.Email = Convert.ToString(dr["EMAIL"]).Trim();
			this.College = Convert.ToString(dr["COLLEGE_NAME"]).Trim();
		}
	}
}

